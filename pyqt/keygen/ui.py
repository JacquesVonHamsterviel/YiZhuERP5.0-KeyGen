"""The main window, rebuilt from Form1.Designer.cs with Qt layouts."""

try:
    from PyQt6.QtCore import Qt
    from PyQt6.QtWidgets import (
        QApplication, QCheckBox, QGridLayout, QGroupBox, QHBoxLayout, QLabel,
        QLineEdit, QMessageBox, QPushButton, QTextEdit, QVBoxLayout, QWidget,
    )
except ImportError:  # PyQt5
    from PyQt5.QtCore import Qt
    from PyQt5.QtWidgets import (
        QApplication, QCheckBox, QGridLayout, QGroupBox, QHBoxLayout, QLabel,
        QLineEdit, QMessageBox, QPushButton, QTextEdit, QVBoxLayout, QWidget,
    )

from .core import KeygenError, Selection, generate
from .modules import (
    ALL_CODE, ALL_LABEL, ALL_TOOLTIP, COLUMNS, MODULES, MODULES_BY_CODE,
)

QTY_FIELD_WIDTH = 48


class KeygenWindow(QWidget):
    def __init__(self):
        super().__init__()
        self.checkboxes = {}   # module code (or ALL_CODE) -> QCheckBox
        self.quantities = {}   # module code (or ALL_CODE) -> QLineEdit

        self.setWindowTitle("Keygen")
        layout = QVBoxLayout(self)
        layout.addLayout(self._build_header())
        layout.addWidget(self._build_feature_box())
        layout.addLayout(self._build_footer())
        self.resize(720, 660)

    # ---------------------------------------------------------------- layout

    def _build_header(self):
        self.install_code = QLineEdit()
        self.install_code.setToolTip("请输入安装代号！")

        self.customer_code = QLineEdit()
        self.customer_code.setMaxLength(6)
        self.customer_code.setToolTip("请输入客服代号！")

        install_column = QVBoxLayout()
        install_column.addWidget(QLabel("安装代号"))
        install_column.addWidget(self.install_code)

        customer_column = QVBoxLayout()
        customer_column.addWidget(QLabel("客户代号"))
        customer_column.addWidget(self.customer_code)

        row = QHBoxLayout()
        row.addLayout(install_column, 3)
        row.addLayout(customer_column, 1)
        return row

    def _build_feature_box(self):
        box = QGroupBox("功能选择")
        box.setToolTip("选取要注册的功能！")
        grid = QGridLayout(box)

        for column_index, column in enumerate(COLUMNS):
            qty_column = column_index * 2
            check_column = qty_column + 1
            for row_index, code in enumerate(column):
                # The original repeats the column headings above every row.
                heading = "功能代号" if (column_index, row_index) == (0, 0) else "功能"
                grid.addWidget(QLabel("用户数"), row_index * 2, qty_column)
                grid.addWidget(QLabel(heading), row_index * 2, check_column)

                quantity = QLineEdit()
                quantity.setFixedWidth(QTY_FIELD_WIDTH)
                if code != ALL_CODE:
                    quantity.setMaxLength(2)
                self.quantities[code] = quantity
                grid.addWidget(quantity, row_index * 2 + 1, qty_column)

                if code == ALL_CODE:
                    checkbox = QCheckBox(ALL_LABEL)
                    checkbox.setToolTip(ALL_TOOLTIP)
                    checkbox.toggled.connect(self._on_all_toggled)
                else:
                    module = MODULES_BY_CODE[code]
                    checkbox = QCheckBox(module.label)
                    checkbox.setToolTip(module.tooltip)
                    checkbox.toggled.connect(self._on_module_toggled)
                self.checkboxes[code] = checkbox
                grid.addWidget(checkbox, row_index * 2 + 1, check_column)

            grid.setColumnStretch(check_column, 1)

        return box

    def _build_footer(self):
        self.company = QLineEdit()
        self.company.setToolTip("请输入要注册的公司名！")

        self.serial = QTextEdit()
        self.serial.setReadOnly(True)
        self.serial.setFixedHeight(72)
        self.serial.setLineWrapMode(QTextEdit.LineWrapMode.WidgetWidth)

        self.password = QLineEdit()
        self.password.setReadOnly(True)

        self.register_button = QPushButton("注册")
        self.register_button.clicked.connect(self.on_register)

        serial_column = QVBoxLayout()
        serial_column.addWidget(QLabel("序列号"))
        serial_column.addWidget(self.serial)

        password_column = QVBoxLayout()
        password_column.addWidget(QLabel("验证口令"))
        password_column.addWidget(self.password)
        password_column.addStretch(1)
        password_column.addWidget(self.register_button)

        results = QHBoxLayout()
        results.addLayout(serial_column, 3)
        results.addLayout(password_column, 1)

        footer = QVBoxLayout()
        footer.addWidget(QLabel("注册公司名"))
        footer.addWidget(self.company)
        footer.addLayout(results)
        return footer

    # ---------------------------------------------------------------- events

    def _on_all_toggled(self, checked):
        """"所有功能" clears every individual module, as in ALL_CheckStateChanged."""
        if not checked:
            return
        for module in MODULES:
            self.checkboxes[module.code].setChecked(False)

    def _on_module_toggled(self, checked):
        """Any individual module clears "所有功能" (BAS_CheckStateChanged)."""
        if not checked:
            return
        self.checkboxes[ALL_CODE].setChecked(False)

    def on_register(self):
        try:
            result = generate(self.read_selection())
        except KeygenError as error:
            QMessageBox.information(self, "提示", str(error))
            return
        self.serial.setPlainText(result.serial)
        self.password.setText(result.password)

    # ------------------------------------------------------------------ data

    def read_selection(self):
        return Selection(
            customer_code=self.customer_code.text(),
            install_code=self.install_code.text(),
            company=self.company.text(),
            all_features=self.checkboxes[ALL_CODE].isChecked(),
            all_quantity=self.quantities[ALL_CODE].text(),
            checked={code for code, box in self.checkboxes.items()
                     if code != ALL_CODE and box.isChecked()},
            quantities={code: field.text() for code, field in self.quantities.items()},
        )


def run(argv):
    app = QApplication(argv)
    window = KeygenWindow()
    window.show()
    return app.exec() if hasattr(app, "exec") else app.exec_()
