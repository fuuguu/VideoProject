namespace VideoProject
{
    partial class Clients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label паспортLabel;
            System.Windows.Forms.Label дата_взятияLabel;
            System.Windows.Forms.Label дата_возвратаLabel;
            System.Windows.Forms.Label отметка_об_оплатеLabel;
            System.Windows.Forms.Label отметка_о_возврате_Label;
            System.Windows.Forms.Label код_кассеты_1Label;
            System.Windows.Forms.Label код_кассеты_2Label;
            System.Windows.Forms.Label код_кассеты_3Label;
            System.Windows.Forms.Label код_сотрудникаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.label1 = new System.Windows.Forms.Label();
            this.видеоПрокатDataSet = new VideoProject.ВидеоПрокатDataSet();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter = new VideoProject.ВидеоПрокатDataSetTableAdapters.КлиентыTableAdapter();
            this.tableAdapterManager = new VideoProject.ВидеоПрокатDataSetTableAdapters.TableAdapterManager();
            this.клиентыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.клиентыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_взятияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_возвратаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_кассеты_1TextBox = new System.Windows.Forms.TextBox();
            this.код_кассеты_2TextBox = new System.Windows.Forms.TextBox();
            this.код_кассеты_3TextBox = new System.Windows.Forms.TextBox();
            this.код_сотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.отметка_об_оплатеComboBox = new System.Windows.Forms.ComboBox();
            this.отметка_о_возврате_ComboBox = new System.Windows.Forms.ComboBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            паспортLabel = new System.Windows.Forms.Label();
            дата_взятияLabel = new System.Windows.Forms.Label();
            дата_возвратаLabel = new System.Windows.Forms.Label();
            отметка_об_оплатеLabel = new System.Windows.Forms.Label();
            отметка_о_возврате_Label = new System.Windows.Forms.Label();
            код_кассеты_1Label = new System.Windows.Forms.Label();
            код_кассеты_2Label = new System.Windows.Forms.Label();
            код_кассеты_3Label = new System.Windows.Forms.Label();
            код_сотрудникаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.видеоПрокатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).BeginInit();
            this.клиентыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(36, 88);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(69, 16);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(36, 137);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(36, 16);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(36, 184);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(73, 16);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(36, 238);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(50, 16);
            адресLabel.TabIndex = 8;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(36, 287);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(70, 16);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
            // 
            // паспортLabel
            // 
            паспортLabel.AutoSize = true;
            паспортLabel.Location = new System.Drawing.Point(36, 346);
            паспортLabel.Name = "паспортLabel";
            паспортLabel.Size = new System.Drawing.Size(66, 16);
            паспортLabel.TabIndex = 12;
            паспортLabel.Text = "Паспорт:";
            // 
            // дата_взятияLabel
            // 
            дата_взятияLabel.AutoSize = true;
            дата_взятияLabel.Location = new System.Drawing.Point(412, 89);
            дата_взятияLabel.Name = "дата_взятияLabel";
            дата_взятияLabel.Size = new System.Drawing.Size(90, 16);
            дата_взятияLabel.TabIndex = 14;
            дата_взятияLabel.Text = "Дата взятия:";
            дата_взятияLabel.Click += new System.EventHandler(this.дата_взятияLabel_Click);
            // 
            // дата_возвратаLabel
            // 
            дата_возвратаLabel.AutoSize = true;
            дата_возвратаLabel.Location = new System.Drawing.Point(412, 137);
            дата_возвратаLabel.Name = "дата_возвратаLabel";
            дата_возвратаLabel.Size = new System.Drawing.Size(108, 16);
            дата_возвратаLabel.TabIndex = 16;
            дата_возвратаLabel.Text = "Дата возврата:";
            // 
            // отметка_об_оплатеLabel
            // 
            отметка_об_оплатеLabel.AutoSize = true;
            отметка_об_оплатеLabel.Location = new System.Drawing.Point(412, 184);
            отметка_об_оплатеLabel.Name = "отметка_об_оплатеLabel";
            отметка_об_оплатеLabel.Size = new System.Drawing.Size(135, 16);
            отметка_об_оплатеLabel.TabIndex = 18;
            отметка_об_оплатеLabel.Text = "Отметка об оплате:";
            // 
            // отметка_о_возврате_Label
            // 
            отметка_о_возврате_Label.AutoSize = true;
            отметка_о_возврате_Label.Location = new System.Drawing.Point(412, 238);
            отметка_о_возврате_Label.Name = "отметка_о_возврате_Label";
            отметка_о_возврате_Label.Size = new System.Drawing.Size(146, 16);
            отметка_о_возврате_Label.TabIndex = 20;
            отметка_о_возврате_Label.Text = "Отметка о возврате,:";
            // 
            // код_кассеты_1Label
            // 
            код_кассеты_1Label.AutoSize = true;
            код_кассеты_1Label.Location = new System.Drawing.Point(412, 284);
            код_кассеты_1Label.Name = "код_кассеты_1Label";
            код_кассеты_1Label.Size = new System.Drawing.Size(100, 16);
            код_кассеты_1Label.TabIndex = 22;
            код_кассеты_1Label.Text = "Код кассеты 1:";
            // 
            // код_кассеты_2Label
            // 
            код_кассеты_2Label.AutoSize = true;
            код_кассеты_2Label.Location = new System.Drawing.Point(412, 346);
            код_кассеты_2Label.Name = "код_кассеты_2Label";
            код_кассеты_2Label.Size = new System.Drawing.Size(100, 16);
            код_кассеты_2Label.TabIndex = 24;
            код_кассеты_2Label.Text = "Код кассеты 2:";
            // 
            // код_кассеты_3Label
            // 
            код_кассеты_3Label.AutoSize = true;
            код_кассеты_3Label.Location = new System.Drawing.Point(412, 405);
            код_кассеты_3Label.Name = "код_кассеты_3Label";
            код_кассеты_3Label.Size = new System.Drawing.Size(100, 16);
            код_кассеты_3Label.TabIndex = 26;
            код_кассеты_3Label.Text = "Код кассеты 3:";
            // 
            // код_сотрудникаLabel
            // 
            код_сотрудникаLabel.AutoSize = true;
            код_сотрудникаLabel.Location = new System.Drawing.Point(412, 455);
            код_сотрудникаLabel.Name = "код_сотрудникаLabel";
            код_сотрудникаLabel.Size = new System.Drawing.Size(114, 16);
            код_сотрудникаLabel.TabIndex = 28;
            код_сотрудникаLabel.Text = "Код сотрудника:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(266, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Клиенты\"";
            // 
            // видеоПрокатDataSet
            // 
            this.видеоПрокатDataSet.DataSetName = "ВидеоПрокатDataSet";
            this.видеоПрокатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.видеоПрокатDataSet;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VideoProject.ВидеоПрокатDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.КассетыTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // клиентыBindingNavigator
            // 
            this.клиентыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.клиентыBindingNavigator.BindingSource = this.клиентыBindingSource;
            this.клиентыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.клиентыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.клиентыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.клиентыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.клиентыBindingNavigatorSaveItem});
            this.клиентыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.клиентыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.клиентыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.клиентыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.клиентыBindingNavigator.Name = "клиентыBindingNavigator";
            this.клиентыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.клиентыBindingNavigator.Size = new System.Drawing.Size(805, 27);
            this.клиентыBindingNavigator.TabIndex = 1;
            this.клиентыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // клиентыBindingNavigatorSaveItem
            // 
            this.клиентыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентыBindingNavigatorSaveItem.Image")));
            this.клиентыBindingNavigatorSaveItem.Name = "клиентыBindingNavigatorSaveItem";
            this.клиентыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.клиентыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентыBindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентыBindingNavigatorSaveItem_Click);
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(127, 82);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(252, 22);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(127, 126);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(252, 22);
            this.имяTextBox.TabIndex = 5;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(127, 178);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(252, 22);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(127, 232);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(252, 22);
            this.адресTextBox.TabIndex = 9;
            // 
            // дата_взятияDateTimePicker
            // 
            this.дата_взятияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "Дата взятия", true));
            this.дата_взятияDateTimePicker.Location = new System.Drawing.Point(585, 83);
            this.дата_взятияDateTimePicker.Name = "дата_взятияDateTimePicker";
            this.дата_взятияDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_взятияDateTimePicker.TabIndex = 15;
            // 
            // дата_возвратаDateTimePicker
            // 
            this.дата_возвратаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "Дата возврата", true));
            this.дата_возвратаDateTimePicker.Location = new System.Drawing.Point(585, 132);
            this.дата_возвратаDateTimePicker.Name = "дата_возвратаDateTimePicker";
            this.дата_возвратаDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.дата_возвратаDateTimePicker.TabIndex = 17;
            // 
            // код_кассеты_1TextBox
            // 
            this.код_кассеты_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Код кассеты 1", true));
            this.код_кассеты_1TextBox.Location = new System.Drawing.Point(585, 284);
            this.код_кассеты_1TextBox.Name = "код_кассеты_1TextBox";
            this.код_кассеты_1TextBox.Size = new System.Drawing.Size(200, 22);
            this.код_кассеты_1TextBox.TabIndex = 23;
            // 
            // код_кассеты_2TextBox
            // 
            this.код_кассеты_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Код кассеты 2", true));
            this.код_кассеты_2TextBox.Location = new System.Drawing.Point(585, 343);
            this.код_кассеты_2TextBox.Name = "код_кассеты_2TextBox";
            this.код_кассеты_2TextBox.Size = new System.Drawing.Size(200, 22);
            this.код_кассеты_2TextBox.TabIndex = 25;
            // 
            // код_кассеты_3TextBox
            // 
            this.код_кассеты_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Код кассеты 3", true));
            this.код_кассеты_3TextBox.Location = new System.Drawing.Point(585, 399);
            this.код_кассеты_3TextBox.Name = "код_кассеты_3TextBox";
            this.код_кассеты_3TextBox.Size = new System.Drawing.Size(200, 22);
            this.код_кассеты_3TextBox.TabIndex = 27;
            // 
            // код_сотрудникаTextBox
            // 
            this.код_сотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Код сотрудника", true));
            this.код_сотрудникаTextBox.Location = new System.Drawing.Point(585, 449);
            this.код_сотрудникаTextBox.Name = "код_сотрудникаTextBox";
            this.код_сотрудникаTextBox.Size = new System.Drawing.Size(200, 22);
            this.код_сотрудникаTextBox.TabIndex = 29;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Телефон", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(127, 284);
            this.maskedTextBox1.Mask = "+7 (999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(252, 22);
            this.maskedTextBox1.TabIndex = 30;
            // 
            // отметка_об_оплатеComboBox
            // 
            this.отметка_об_оплатеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Отметка об оплате", true));
            this.отметка_об_оплатеComboBox.FormattingEnabled = true;
            this.отметка_об_оплатеComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.отметка_об_оплатеComboBox.Location = new System.Drawing.Point(585, 178);
            this.отметка_об_оплатеComboBox.Name = "отметка_об_оплатеComboBox";
            this.отметка_об_оплатеComboBox.Size = new System.Drawing.Size(200, 24);
            this.отметка_об_оплатеComboBox.TabIndex = 31;
            // 
            // отметка_о_возврате_ComboBox
            // 
            this.отметка_о_возврате_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Отметка о возврате,", true));
            this.отметка_о_возврате_ComboBox.FormattingEnabled = true;
            this.отметка_о_возврате_ComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.отметка_о_возврате_ComboBox.Location = new System.Drawing.Point(585, 230);
            this.отметка_о_возврате_ComboBox.Name = "отметка_о_возврате_ComboBox";
            this.отметка_о_возврате_ComboBox.Size = new System.Drawing.Size(200, 24);
            this.отметка_о_возврате_ComboBox.TabIndex = 32;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Паспорт", true));
            this.maskedTextBox2.Location = new System.Drawing.Point(127, 343);
            this.maskedTextBox2.Mask = "00000-000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(252, 22);
            this.maskedTextBox2.TabIndex = 33;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 34;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 37);
            this.button2.TabIndex = 35;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(539, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 37);
            this.button3.TabIndex = 36;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(159, 623);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 37);
            this.button4.TabIndex = 37;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(344, 623);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 37);
            this.button5.TabIndex = 38;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(539, 623);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 37);
            this.button6.TabIndex = 39;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(344, 700);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 37);
            this.button7.TabIndex = 40;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 749);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.отметка_о_возврате_ComboBox);
            this.Controls.Add(this.отметка_об_оплатеComboBox);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(код_сотрудникаLabel);
            this.Controls.Add(this.код_сотрудникаTextBox);
            this.Controls.Add(код_кассеты_3Label);
            this.Controls.Add(this.код_кассеты_3TextBox);
            this.Controls.Add(код_кассеты_2Label);
            this.Controls.Add(this.код_кассеты_2TextBox);
            this.Controls.Add(код_кассеты_1Label);
            this.Controls.Add(this.код_кассеты_1TextBox);
            this.Controls.Add(отметка_о_возврате_Label);
            this.Controls.Add(отметка_об_оплатеLabel);
            this.Controls.Add(дата_возвратаLabel);
            this.Controls.Add(this.дата_возвратаDateTimePicker);
            this.Controls.Add(дата_взятияLabel);
            this.Controls.Add(this.дата_взятияDateTimePicker);
            this.Controls.Add(паспортLabel);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(this.клиентыBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.Text = "Таблица \"Клиенты\"";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.видеоПрокатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingNavigator)).EndInit();
            this.клиентыBindingNavigator.ResumeLayout(false);
            this.клиентыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ВидеоПрокатDataSet видеоПрокатDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private ВидеоПрокатDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private ВидеоПрокатDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton клиентыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_взятияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_возвратаDateTimePicker;
        private System.Windows.Forms.TextBox код_кассеты_1TextBox;
        private System.Windows.Forms.TextBox код_кассеты_2TextBox;
        private System.Windows.Forms.TextBox код_кассеты_3TextBox;
        private System.Windows.Forms.TextBox код_сотрудникаTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox отметка_об_оплатеComboBox;
        private System.Windows.Forms.ComboBox отметка_о_возврате_ComboBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}