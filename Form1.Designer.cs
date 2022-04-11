namespace Examen11042022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userslistView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.surnameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.activeColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.inUsecolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.titleLabel = new System.Windows.Forms.Label();
            this.subTitleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.skillsTabControl = new System.Windows.Forms.TabControl();
            this.Customer = new System.Windows.Forms.TabPage();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.feelabel = new System.Windows.Forms.Label();
            this.unsubscribeTextBox = new System.Windows.Forms.TextBox();
            this.subscribeDateTextBox = new System.Windows.Forms.TextBox();
            this.unsubscribeLabel = new System.Windows.Forms.Label();
            this.subscribeDateLabel = new System.Windows.Forms.Label();
            this.Trainer = new System.Windows.Forms.TabPage();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.contractStartDateTextBox = new System.Windows.Forms.TextBox();
            this.contractStartDateLabel = new System.Windows.Forms.Label();
            this.contractEndDateTextBox = new System.Windows.Forms.TextBox();
            this.contractEndDateLabel = new System.Windows.Forms.Label();
            this.sportsLabel = new System.Windows.Forms.Label();
            this.sportsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Assistant = new System.Windows.Forms.TabPage();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundComboBox = new System.Windows.Forms.ComboBox();
            this.baseSalarytextBox = new System.Windows.Forms.TextBox();
            this.baseSalaryLabel = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.functionLabel = new System.Windows.Forms.Label();
            this.contractStartDatePersonaTextBox = new System.Windows.Forms.TextBox();
            this.contractStartDatePersonalLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.inUseCheckBox = new System.Windows.Forms.CheckBox();
            this.skillsTabControl.SuspendLayout();
            this.Customer.SuspendLayout();
            this.Trainer.SuspendLayout();
            this.Assistant.SuspendLayout();
            this.SuspendLayout();
            // 
            // userslistView
            // 
            this.userslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.surnameColumnHeader,
            this.activeColumnHeader,
            this.inUsecolumnHeader});
            this.userslistView.HideSelection = false;
            this.userslistView.Location = new System.Drawing.Point(8, 121);
            this.userslistView.Name = "userslistView";
            this.userslistView.Size = new System.Drawing.Size(467, 580);
            this.userslistView.TabIndex = 1;
            this.userslistView.UseCompatibleStateImageBehavior = false;
            this.userslistView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Nombre";
            this.nameColumnHeader.Width = 100;
            // 
            // surnameColumnHeader
            // 
            this.surnameColumnHeader.Text = "Apellidos";
            this.surnameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.surnameColumnHeader.Width = 120;
            // 
            // activeColumnHeader
            // 
            this.activeColumnHeader.Text = "Activo";
            this.activeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activeColumnHeader.Width = 80;
            // 
            // inUsecolumnHeader
            // 
            this.inUsecolumnHeader.Text = "En las instalciones";
            this.inUsecolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inUsecolumnHeader.Width = 160;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(166, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(199, 41);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Lista Usuarios";
            // 
            // subTitleLabel
            // 
            this.subTitleLabel.AutoSize = true;
            this.subTitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subTitleLabel.Location = new System.Drawing.Point(614, 53);
            this.subTitleLabel.Name = "subTitleLabel";
            this.subTitleLabel.Size = new System.Drawing.Size(195, 41);
            this.subTitleLabel.TabIndex = 3;
            this.subTitleLabel.Text = "Ficha Usuario";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(508, 124);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 25);
            this.idLabel.TabIndex = 5;
            this.idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(542, 121);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(75, 31);
            this.idTextBox.TabIndex = 4;
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(493, 176);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(43, 25);
            this.dniLabel.TabIndex = 7;
            this.dniLabel.Text = "DNI";
            // 
            // dniTextBox
            // 
            this.dniTextBox.Location = new System.Drawing.Point(542, 170);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(75, 31);
            this.dniTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(633, 121);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 25);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Nombre";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(725, 121);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(262, 31);
            this.nameTextBox.TabIndex = 8;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(633, 173);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(86, 25);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Apellidos";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(725, 173);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(262, 31);
            this.surnameTextBox.TabIndex = 10;
            // 
            // skillsTabControl
            // 
            this.skillsTabControl.Controls.Add(this.Customer);
            this.skillsTabControl.Controls.Add(this.Trainer);
            this.skillsTabControl.Controls.Add(this.Assistant);
            this.skillsTabControl.Location = new System.Drawing.Point(493, 236);
            this.skillsTabControl.Name = "skillsTabControl";
            this.skillsTabControl.SelectedIndex = 0;
            this.skillsTabControl.Size = new System.Drawing.Size(494, 408);
            this.skillsTabControl.TabIndex = 12;
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.feeTextBox);
            this.Customer.Controls.Add(this.feelabel);
            this.Customer.Controls.Add(this.unsubscribeTextBox);
            this.Customer.Controls.Add(this.subscribeDateTextBox);
            this.Customer.Controls.Add(this.unsubscribeLabel);
            this.Customer.Controls.Add(this.subscribeDateLabel);
            this.Customer.Location = new System.Drawing.Point(4, 34);
            this.Customer.Name = "Customer";
            this.Customer.Padding = new System.Windows.Forms.Padding(3);
            this.Customer.Size = new System.Drawing.Size(486, 370);
            this.Customer.TabIndex = 0;
            this.Customer.Text = "Cliente";
            this.Customer.UseVisualStyleBackColor = true;
            // 
            // feeTextBox
            // 
            this.feeTextBox.Location = new System.Drawing.Point(191, 234);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(150, 31);
            this.feeTextBox.TabIndex = 5;
            // 
            // feelabel
            // 
            this.feelabel.AutoSize = true;
            this.feelabel.Location = new System.Drawing.Point(45, 240);
            this.feelabel.Name = "feelabel";
            this.feelabel.Size = new System.Drawing.Size(53, 25);
            this.feelabel.TabIndex = 4;
            this.feelabel.Text = "Tarifa";
            // 
            // unsubscribeTextBox
            // 
            this.unsubscribeTextBox.Location = new System.Drawing.Point(191, 163);
            this.unsubscribeTextBox.Name = "unsubscribeTextBox";
            this.unsubscribeTextBox.Size = new System.Drawing.Size(237, 31);
            this.unsubscribeTextBox.TabIndex = 3;
            // 
            // subscribeDateTextBox
            // 
            this.subscribeDateTextBox.Location = new System.Drawing.Point(191, 85);
            this.subscribeDateTextBox.Name = "subscribeDateTextBox";
            this.subscribeDateTextBox.Size = new System.Drawing.Size(237, 31);
            this.subscribeDateTextBox.TabIndex = 2;
            // 
            // unsubscribeLabel
            // 
            this.unsubscribeLabel.AutoSize = true;
            this.unsubscribeLabel.Location = new System.Drawing.Point(45, 163);
            this.unsubscribeLabel.Name = "unsubscribeLabel";
            this.unsubscribeLabel.Size = new System.Drawing.Size(120, 25);
            this.unsubscribeLabel.TabIndex = 1;
            this.unsubscribeLabel.Text = "Fecha de baja";
            // 
            // subscribeDateLabel
            // 
            this.subscribeDateLabel.AutoSize = true;
            this.subscribeDateLabel.Location = new System.Drawing.Point(45, 85);
            this.subscribeDateLabel.Name = "subscribeDateLabel";
            this.subscribeDateLabel.Size = new System.Drawing.Size(118, 25);
            this.subscribeDateLabel.TabIndex = 0;
            this.subscribeDateLabel.Text = "Fecha de Alta";
            // 
            // Trainer
            // 
            this.Trainer.Controls.Add(this.SalaryTextBox);
            this.Trainer.Controls.Add(this.SalaryLabel);
            this.Trainer.Controls.Add(this.contractStartDateTextBox);
            this.Trainer.Controls.Add(this.contractStartDateLabel);
            this.Trainer.Controls.Add(this.contractEndDateTextBox);
            this.Trainer.Controls.Add(this.contractEndDateLabel);
            this.Trainer.Controls.Add(this.sportsLabel);
            this.Trainer.Controls.Add(this.sportsCheckedListBox);
            this.Trainer.Location = new System.Drawing.Point(4, 34);
            this.Trainer.Name = "Trainer";
            this.Trainer.Padding = new System.Windows.Forms.Padding(3);
            this.Trainer.Size = new System.Drawing.Size(486, 370);
            this.Trainer.TabIndex = 1;
            this.Trainer.Text = "Entrenador";
            this.Trainer.UseVisualStyleBackColor = true;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(228, 319);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(232, 31);
            this.SalaryTextBox.TabIndex = 7;
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(34, 325);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(134, 25);
            this.SalaryLabel.TabIndex = 6;
            this.SalaryLabel.Text = "Precio por hora";
            // 
            // contractStartDateTextBox
            // 
            this.contractStartDateTextBox.Location = new System.Drawing.Point(228, 202);
            this.contractStartDateTextBox.Name = "contractStartDateTextBox";
            this.contractStartDateTextBox.Size = new System.Drawing.Size(232, 31);
            this.contractStartDateTextBox.TabIndex = 5;
            // 
            // contractStartDateLabel
            // 
            this.contractStartDateLabel.AutoSize = true;
            this.contractStartDateLabel.Location = new System.Drawing.Point(34, 202);
            this.contractStartDateLabel.Name = "contractStartDateLabel";
            this.contractStartDateLabel.Size = new System.Drawing.Size(185, 25);
            this.contractStartDateLabel.TabIndex = 4;
            this.contractStartDateLabel.Text = "Fecha de contratación";
            // 
            // contractEndDateTextBox
            // 
            this.contractEndDateTextBox.Location = new System.Drawing.Point(228, 262);
            this.contractEndDateTextBox.Name = "contractEndDateTextBox";
            this.contractEndDateTextBox.Size = new System.Drawing.Size(232, 31);
            this.contractEndDateTextBox.TabIndex = 3;
            // 
            // contractEndDateLabel
            // 
            this.contractEndDateLabel.AutoSize = true;
            this.contractEndDateLabel.Location = new System.Drawing.Point(34, 268);
            this.contractEndDateLabel.Name = "contractEndDateLabel";
            this.contractEndDateLabel.Size = new System.Drawing.Size(163, 25);
            this.contractEndDateLabel.TabIndex = 2;
            this.contractEndDateLabel.Text = "Fin de contratación";
            // 
            // sportsLabel
            // 
            this.sportsLabel.AutoSize = true;
            this.sportsLabel.Location = new System.Drawing.Point(34, 50);
            this.sportsLabel.Name = "sportsLabel";
            this.sportsLabel.Size = new System.Drawing.Size(164, 50);
            this.sportsLabel.TabIndex = 1;
            this.sportsLabel.Text = "Entrenamientos del\nque es monitor";
            // 
            // sportsCheckedListBox
            // 
            this.sportsCheckedListBox.FormattingEnabled = true;
            this.sportsCheckedListBox.Items.AddRange(new object[] {
            "Entrenador personal",
            "CrossFit",
            "Musculacion",
            "Boxeo",
            "Lucha personal",
            "Judo",
            "Lucha Olimpica",
            "Natación",
            "Velocidad",
            "Salto",
            "Mantenimeinto",
            "Ponerse en forma",
            "Salud",
            "Recuperación"});
            this.sportsCheckedListBox.Location = new System.Drawing.Point(228, 36);
            this.sportsCheckedListBox.Name = "sportsCheckedListBox";
            this.sportsCheckedListBox.Size = new System.Drawing.Size(232, 144);
            this.sportsCheckedListBox.TabIndex = 0;
            // 
            // Assistant
            // 
            this.Assistant.Controls.Add(this.roundLabel);
            this.Assistant.Controls.Add(this.roundComboBox);
            this.Assistant.Controls.Add(this.baseSalarytextBox);
            this.Assistant.Controls.Add(this.baseSalaryLabel);
            this.Assistant.Controls.Add(this.functionTextBox);
            this.Assistant.Controls.Add(this.functionLabel);
            this.Assistant.Controls.Add(this.contractStartDatePersonaTextBox);
            this.Assistant.Controls.Add(this.contractStartDatePersonalLabel);
            this.Assistant.Location = new System.Drawing.Point(4, 34);
            this.Assistant.Name = "Assistant";
            this.Assistant.Padding = new System.Windows.Forms.Padding(3);
            this.Assistant.Size = new System.Drawing.Size(486, 370);
            this.Assistant.TabIndex = 2;
            this.Assistant.Text = "Otro Personal";
            this.Assistant.UseVisualStyleBackColor = true;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Location = new System.Drawing.Point(45, 284);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(101, 25);
            this.roundLabel.TabIndex = 7;
            this.roundLabel.Text = "roundLabel";
            // 
            // roundComboBox
            // 
            this.roundComboBox.FormattingEnabled = true;
            this.roundComboBox.Items.AddRange(new object[] {
            "Mañana",
            "Medio dia",
            "Tarde",
            "Noche"});
            this.roundComboBox.Location = new System.Drawing.Point(248, 276);
            this.roundComboBox.Name = "roundComboBox";
            this.roundComboBox.Size = new System.Drawing.Size(182, 33);
            this.roundComboBox.TabIndex = 6;
            // 
            // baseSalarytextBox
            // 
            this.baseSalarytextBox.Location = new System.Drawing.Point(248, 207);
            this.baseSalarytextBox.Name = "baseSalarytextBox";
            this.baseSalarytextBox.Size = new System.Drawing.Size(182, 31);
            this.baseSalarytextBox.TabIndex = 5;
            // 
            // baseSalaryLabel
            // 
            this.baseSalaryLabel.AutoSize = true;
            this.baseSalaryLabel.Location = new System.Drawing.Point(45, 213);
            this.baseSalaryLabel.Name = "baseSalaryLabel";
            this.baseSalaryLabel.Size = new System.Drawing.Size(65, 25);
            this.baseSalaryLabel.TabIndex = 4;
            this.baseSalaryLabel.Text = "Salario";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(248, 123);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(182, 31);
            this.functionTextBox.TabIndex = 3;
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Location = new System.Drawing.Point(45, 129);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(69, 25);
            this.functionLabel.TabIndex = 2;
            this.functionLabel.Text = "Trabajo";
            // 
            // contractStartDatePersonaTextBox
            // 
            this.contractStartDatePersonaTextBox.Location = new System.Drawing.Point(248, 50);
            this.contractStartDatePersonaTextBox.Name = "contractStartDatePersonaTextBox";
            this.contractStartDatePersonaTextBox.Size = new System.Drawing.Size(182, 31);
            this.contractStartDatePersonaTextBox.TabIndex = 1;
            // 
            // contractStartDatePersonalLabel
            // 
            this.contractStartDatePersonalLabel.AutoSize = true;
            this.contractStartDatePersonalLabel.Location = new System.Drawing.Point(45, 56);
            this.contractStartDatePersonalLabel.Name = "contractStartDatePersonalLabel";
            this.contractStartDatePersonalLabel.Size = new System.Drawing.Size(185, 25);
            this.contractStartDatePersonalLabel.TabIndex = 0;
            this.contractStartDatePersonalLabel.Text = "Fecha de contratación";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(730, 667);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(112, 34);
            this.newButton.TabIndex = 13;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(871, 667);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 34);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(493, 650);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(138, 29);
            this.activeCheckBox.TabIndex = 15;
            this.activeCheckBox.Text = "¿Está activo?";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // inUseCheckBox
            // 
            this.inUseCheckBox.AutoSize = true;
            this.inUseCheckBox.Location = new System.Drawing.Point(493, 685);
            this.inUseCheckBox.Name = "inUseCheckBox";
            this.inUseCheckBox.Size = new System.Drawing.Size(179, 29);
            this.inUseCheckBox.TabIndex = 16;
            this.inUseCheckBox.Text = "En las instalciones";
            this.inUseCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 768);
            this.Controls.Add(this.inUseCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.skillsTabControl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.subTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.userslistView);
            this.Name = "Form1";
            this.Text = "GymStayInHome";
            this.skillsTabControl.ResumeLayout(false);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.Trainer.ResumeLayout(false);
            this.Trainer.PerformLayout();
            this.Assistant.ResumeLayout(false);
            this.Assistant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView userslistView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subTitleLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TabControl skillsTabControl;
        private System.Windows.Forms.TabPage Customer;
        private System.Windows.Forms.TabPage Trainer;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage Assistant;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader surnameColumnHeader;
        private System.Windows.Forms.ColumnHeader activeColumnHeader;
        private System.Windows.Forms.ColumnHeader inUsecolumnHeader;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.CheckBox inUseCheckBox;
        private System.Windows.Forms.TextBox unsubscribeTextBox;
        private System.Windows.Forms.TextBox subscribeDateTextBox;
        private System.Windows.Forms.Label unsubscribeLabel;
        private System.Windows.Forms.Label subscribeDateLabel;
        private System.Windows.Forms.TextBox feeTextBox;
        private System.Windows.Forms.Label feelabel;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label SalaryLabel;
        private System.Windows.Forms.TextBox contractStartDateTextBox;
        private System.Windows.Forms.Label contractStartDateLabel;
        private System.Windows.Forms.TextBox contractEndDateTextBox;
        private System.Windows.Forms.Label contractEndDateLabel;
        private System.Windows.Forms.Label sportsLabel;
        private System.Windows.Forms.CheckedListBox sportsCheckedListBox;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundComboBox;
        private System.Windows.Forms.TextBox baseSalarytextBox;
        private System.Windows.Forms.Label baseSalaryLabel;
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.TextBox contractStartDatePersonaTextBox;
        private System.Windows.Forms.Label contractStartDatePersonalLabel;
    }
}
