# Drives the original TPA.exe (== 直接下载可用-易助 5.0-KeyGen.exe) headlessly and
# records, for each case in cases.json, the serial/password it produces together
# with the exact control state at click time.  compare.py then feeds that same
# state into keygen.core and diffs the two.
#
# Requires: Windows + .NET Framework (the exe is a VB WinForms binary).  Run from
# anywhere:  powershell -ExecutionPolicy Bypass -File run_exe.ps1
#
# NOTE: the exe encodes the company name with Encoding.Default (the system ANSI
# code page).  For the Chinese company-name cases to match the port's GBK
# implementation, the machine's "language for non-Unicode programs" must be
# Chinese (code page 936).  ASCII company names match on any locale.

$ErrorActionPreference = 'Stop'
$root      = (Resolve-Path (Join-Path $PSScriptRoot '..\..\..')).Path
$exePath   = Join-Path $root 'CS\TPA\bin\Debug\TPA.exe'
if (-not (Test-Path $exePath)) {
    $exePath = Join-Path $root '直接下载可用-易助 5.0-KeyGen.exe'
}
$casesPath = Join-Path $PSScriptRoot 'cases.json'
$outPath   = Join-Path $PSScriptRoot 'exe_results.json'

$worker = {
    param($exePath, $casesPath, $outPath)
    Add-Type -AssemblyName System.Windows.Forms
    Add-Type -AssemblyName System.Drawing
    $asm = [Reflection.Assembly]::LoadFrom($exePath)
    $t = $asm.GetType('WindowsApplication1.Form1')
    $bf = [Reflection.BindingFlags]'NonPublic,Public,Instance'
    # The decompiled VB WithEvents controls are exposed as virtual PROPERTIES
    # (backing field _Name), so reflect with GetProperty, not GetField.
    function GetCtl($form, $name) {
        $p = $t.GetProperty($name, $bf)
        if ($null -ne $p) { return $p.GetValue($form) }
        throw "no control $name"
    }

    $moduleNames = @('YSF','PJM','KJS','RGS','SGM','CRM','GZS','ZCS','SXM','SCM','GYS',
                     'JCA','CWB','COP','PUR','INV','WLB','FIB','SYS','BAS','QMS','RMA')

    $casesJson = [System.IO.File]::ReadAllText($casesPath, [System.Text.Encoding]::UTF8)
    $cases = $casesJson | ConvertFrom-Json
    $results = @()
    foreach ($c in $cases) {
        # Do NOT Show() the form: My.Settings data-binding reloads on the Load
        # event and would overwrite the values we set here.
        $form = [Activator]::CreateInstance($t)
        (GetCtl $form 'CCode').Text  = [string]$c.CCode
        (GetCtl $form 'SN').Text     = [string]$c.SN
        (GetCtl $form 'REGSTR').Text = [string]$c.REGSTR
        if ($c.ALL) {
            (GetCtl $form 'ALLQTY').Text = [string]$c.ALLQTY
            (GetCtl $form 'ALL').Checked = $true
        } else {
            foreach ($mn in $moduleNames) {
                if ($c.modules.PSObject.Properties.Name -contains $mn) {
                    (GetCtl $form ($mn + 'QTY')).Text = [string]$c.modules.$mn
                    (GetCtl $form $mn).Checked = $true
                }
            }
        }
        $t.GetMethod('Button1_Click', $bf).Invoke($form, @($null, [EventArgs]::Empty))

        # Read the control state BACK so the comparison uses exactly what the exe
        # saw (any event-handler side effects included).
        $modState = @{}
        foreach ($mn in $moduleNames) {
            $modState[$mn] = @{ checked = [bool](GetCtl $form $mn).Checked; qty = [string](GetCtl $form ($mn + 'QTY')).Text }
        }
        $results += [pscustomobject]@{
            name    = $c.name
            CCode   = [string](GetCtl $form 'CCode').Text
            SN      = [string](GetCtl $form 'SN').Text
            REGSTR  = [string](GetCtl $form 'REGSTR').Text
            ALL     = [bool](GetCtl $form 'ALL').Checked
            ALLQTY  = [string](GetCtl $form 'ALLQTY').Text
            modules = $modState
            KEY     = [string](GetCtl $form 'KEY').Text
            PW      = [string](GetCtl $form 'PW').Text
        }
        $form.Dispose()
    }
    $json = $results | ConvertTo-Json -Depth 8
    [System.IO.File]::WriteAllText($outPath, $json, [System.Text.UTF8Encoding]::new($false))
    return "wrote $($results.Count) results to $outPath"
}

# WinForms needs an STA thread.
$rs = [runspacefactory]::CreateRunspace()
$rs.ApartmentState = 'STA'
$rs.ThreadOptions  = 'ReuseThread'
$rs.Open()
$ps = [powershell]::Create()
$ps.Runspace = $rs
[void]$ps.AddScript($worker).AddArgument($exePath).AddArgument($casesPath).AddArgument($outPath)
$out = $ps.Invoke()
if ($ps.HadErrors) {
    Write-Output 'ERRORS:'
    foreach ($er in $ps.Streams.Error) { Write-Output ("  " + $er.ToString()) }
}
Write-Output $out
$ps.Dispose(); $rs.Close()
