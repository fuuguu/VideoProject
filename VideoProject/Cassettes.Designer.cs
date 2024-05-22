namespace VideoProject
{
    partial class Cassettes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cassettes));
            System.Windows.Forms.Label наименование_фильмаLabel;
            System.Windows.Forms.Label год_созданиеLabel;
            System.Windows.Forms.Label производительLabel;
            System.Windows.Forms.Label странаLabel;
            System.Windows.Forms.Label главный_актёрLabel;
            System.Windows.Forms.Label дата_записиLabel;
            System.Windows.Forms.Label код_жанраLabel;
            System.Windows.Forms.Label ценаLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.видеоПрокатDataSet = new VideoProject.ВидеоПрокатDataSet();
            this.кассетыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кассетыTableAdapter = new VideoProject.ВидеоПрокатDataSetTableAdapters.КассетыTableAdapter();
            this.tableAdapterManager = new VideoProject.ВидеоПрокатDataSetTableAdapters.TableAdapterManager();
            this.кассетыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.кассетыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.наименование_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.год_созданиеDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.производительTextBox = new System.Windows.Forms.TextBox();
            this.странаTextBox = new System.Windows.Forms.TextBox();
            this.главный_актёрTextBox = new System.Windows.Forms.TextBox();
            this.дата_записиDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_жанраTextBox = new System.Windows.Forms.TextBox();
            this.ценаTextBox = new System.Windows.Forms.TextBox();
            наименование_фильмаLabel = new System.Windows.Forms.Label();
            год_созданиеLabel = new System.Windows.Forms.Label();
            производительLabel = new System.Windows.Forms.Label();
            странаLabel = new System.Windows.Forms.Label();
            главный_актёрLabel = new System.Windows.Forms.Label();
            дата_записиLabel = new System.Windows.Forms.Label();
            код_жанраLabel = new System.Windows.Forms.Label();
            ценаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.видеоПрокатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассетыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассетыBindingNavigator)).BeginInit();
            this.кассетыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Кассеты\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // видеоПрокатDataSet
            // 
            this.видеоПрокатDataSet.DataSetName = "ВидеоПрокатDataSet";
            this.видеоПрокатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кассетыBindingSource
            // 
            this.кассетыBindingSource.DataMember = "Кассеты";
            this.кассетыBindingSource.DataSource = this.видеоПрокатDataSet;
            // 
            // кассетыTableAdapter
            // 
            this.кассетыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VideoProject.ВидеоПрокатDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.ЖанрыTableAdapter = null;
            this.tableAdapterManager.КассетыTableAdapter = this.кассетыTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // кассетыBindingNavigator
            // 
            this.кассетыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.кассетыBindingNavigator.BindingSource = this.кассетыBindingSource;
            this.кассетыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.кассетыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.кассетыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.кассетыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.кассетыBindingNavigatorSaveItem});
            this.кассетыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.кассетыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.кассетыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.кассетыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.кассетыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.кассетыBindingNavigator.Name = "кассетыBindingNavigator";
            this.кассетыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.кассетыBindingNavigator.Size = new System.Drawing.Size(476, 27);
            this.кассетыBindingNavigator.TabIndex = 1;
            this.кассетыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // кассетыBindingNavigatorSaveItem
            // 
            this.кассетыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кассетыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("кассетыBindingNavigatorSaveItem.Image")));
            this.кассетыBindingNavigatorSaveItem.Name = "кассетыBindingNavigatorSaveItem";
            this.кассетыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.кассетыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.кассетыBindingNavigatorSaveItem.Click += new System.EventHandler(this.кассетыBindingNavigatorSaveItem_Click);
            // 
            // наименование_фильмаLabel
            // 
            наименование_фильмаLabel.AutoSize = true;
            наименование_фильмаLabel.Location = new System.Drawing.Point(14, 89);
            наименование_фильмаLabel.Name = "наименование_фильмаLabel";
            наименование_фильмаLabel.Size = new System.Drawing.Size(163, 16);
            наименование_фильмаLabel.TabIndex = 2;
            наименование_фильмаLabel.Text = "Наименование фильма:";
            // 
            // наименование_фильмаTextBox
            // 
            this.наименование_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кассетыBindingSource, "Наименование фильма", true));
            this.наименование_фильмаTextBox.Location = new System.Drawing.Point(205, 83);
            this.наименование_фильмаTextBox.Name = "наименование_фильмаTextBox";
            this.наименование_фильмаTextBox.Size = new System.Drawing.Size(245, 22);
            this.наименование_фильмаTextBox.TabIndex = 3;
            // 
            // год_созданиеLabel
            // 
            год_созданиеLabel.AutoSize = true;
            год_созданиеLabel.Location = new System.Drawing.Point(14, 136);
            год_созданиеLabel.Name = "год_созданиеLabel";
            год_созданиеLabel.Size = new System.Drawing.Size(99, 16);
            год_созданиеLabel.TabIndex = 4;
            год_созданиеLabel.Text = "Год создание:";
            // 
            // год_созданиеDateTimePicker
            // 
            this.год_созданиеDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.кассетыBindingSource, "Год создание", true));
            this.год_созданиеDateTimePicker.Location = new System.Drawing.Point(205, 130);
            this.год_созданиеDateTimePicker.Name = "год_созданиеDateTimePicker";
            this.год_созданиеDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.год_созданиеDateTimePicker.TabIndex = 5;
            // 
            // производительLabel
            // 
            производительLabel.AutoSize = true;
            производительLabel.Location = new System.Drawing.Point(14, 179);
            производительLabel.Name = "производительLabel";
            производительLabel.Size = new System.Drawing.Size(114, 16);
            производительLabel.TabIndex = 6;
            производительLabel.Text = "Производитель:";
            // 
            // производительTextBox
            // 
            this.производительTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кассетыBindingSource, "Производитель", true));
            this.производительTextBox.Location = new System.Drawing.Point(205, 173);
            this.производительTextBox.Name = "производительTextBox";
            this.производительTextBox.Size = new System.Drawing.Size(245, 22);
            this.производительTextBox.TabIndex = 7;
            // 
            // странаLabel
            // 
            странаLabel.AutoSize = true;
            странаLabel.Location = new System.Drawing.Point(14, 226);
            странаLabel.Name = "странаLabel";
            странаLabel.Size = new System.Drawing.Size(58, 16);
            странаLabel.TabIndex = 8;
            странаLabel.Text = "Страна:";
            // 
            // странаTextBox
            // 
            this.странаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кассетыBindingSource, "Страна", true));
            this.странаTextBox.Location = new System.Drawing.Point(205, 220);
            this.странаTextBox.Name = "странаTextBox";
            this.странаTextBox.Size = new System.Drawing.Size(245, 22);
            this.странаTextBox.TabIndex = 9;
            // 
            // главный_актёрLabel
            // 
            главный_актёрLabel.AutoSize = true;
            главный_актёрLabel.Location = new System.Drawing.Point(14, 274);
            главный_актёрLabel.Name = "главный_актёрLabel";
            главный_актёрLabel.Size = new System.Drawing.Size(107, 16);
            главный_актёрLabel.TabIndex = 10;
            главный_актёрLabel.Text = "Главный актёр:";
            // 
            // главный_актёрTextBox
            // 
            this.главный_актёрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кассетыBindingSource, "Главный актёр", true));
            this.главный_актёрTextBox.Location = new System.Drawing.Point(205, 268);
            this.главный_актёрTextBox.Name = "главный_актёрTextBox";
            this.главный_актёрTextBox.Size = new System.Drawing.Size(245, 22);
            this.главный_актёрTextBox.TabIndex = 11;
            // 
            // дата_записиLabel
            // 
            дата_записиLabel.AutoSize = true;
            дата_записиLabel.Location = new System.Drawing.Point(14, 323);
            дата_записиLabel.Name = "дата_записиLabel";
            дата_записиLabel.Size = new System.Drawing.Size(92, 16);
            дата_записиLabel.TabIndex = 12;
            дата_записиLabel.Text = "Дата записи:";
            // 
            // дата_записиDateTimePicker
            // 
            this.дата_записиDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.кассетыBindingSource, "Дата записи", true));
            this.дата_записиDateTimePicker.Location = new System.Drawing.Point(205, 317);
            this.дата_записиDateTimePicker.Name = "дата_записиDateTimePicker";
            this.дата_записиDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.дата_записиDateTimePicker.TabIndex = 13;
            // 
            // код_жанраLabel
            // 
            код_жанраLabel.AutoSize = true;
            код_жанраLabel.Location = new System.Drawing.Point(14, 371);
            код_жанраLabel.Name = "код_жанраLabel";
            код_жанраLabel.Size = new System.Drawing.Size(78, 16);
            код_жанраLabel.TabIndex = 14;
            код_жанраLabel.Text = "Код жанра:";
            // 
            // код_жанраTextBox
            // 
            this.код_жанраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кассетыBindingSource, "Код жанра", true));
            this.код_жанраTextBox.Location = new System.Drawing.Point(205, 365);
            this.код_жанраTextBox.Name = "код_жанраTextBox";
            this.код_жанраTextBox.Size = new System.Drawing.Size(245, 22);
            this.код_жанраTextBox.TabIndex = 15;
            // 
            // ценаLabel
            // 
            ценаLabel.AutoSize = true;
            ценаLabel.Location = new System.Drawing.Point(14, 419);
            ценаLabel.Name = "ценаLabel";
            ценаLabel.Size = new System.Drawing.Size(43, 16);
            ценаLabel.TabIndex = 16;
            ценаLabel.Text = "Цена:";
            // 
            // ценаTextBox
            // 
            this.ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кассетыBindingSource, "Цена", true));
            this.ценаTextBox.Location = new System.Drawing.Point(205, 413);
            this.ценаTextBox.Name = "ценаTextBox";
            this.ценаTextBox.Size = new System.Drawing.Size(245, 22);
            this.ценаTextBox.TabIndex = 17;
            // 
            // Cassettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 496);
            this.Controls.Add(ценаLabel);
            this.Controls.Add(this.ценаTextBox);
            this.Controls.Add(код_жанраLabel);
            this.Controls.Add(this.код_жанраTextBox);
            this.Controls.Add(дата_записиLabel);
            this.Controls.Add(this.дата_записиDateTimePicker);
            this.Controls.Add(главный_актёрLabel);
            this.Controls.Add(this.главный_актёрTextBox);
            this.Controls.Add(странаLabel);
            this.Controls.Add(this.странаTextBox);
            this.Controls.Add(производительLabel);
            this.Controls.Add(this.производительTextBox);
            this.Controls.Add(год_созданиеLabel);
            this.Controls.Add(this.год_созданиеDateTimePicker);
            this.Controls.Add(наименование_фильмаLabel);
            this.Controls.Add(this.наименование_фильмаTextBox);
            this.Controls.Add(this.кассетыBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cassettes";
            this.Text = "Таблица \"Кассеты\"";
            this.Load += new System.EventHandler(this.Cassettes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.видеоПрокатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассетыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кассетыBindingNavigator)).EndInit();
            this.кассетыBindingNavigator.ResumeLayout(false);
            this.кассетыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ВидеоПрокатDataSet видеоПрокатDataSet;
        private System.Windows.Forms.BindingSource кассетыBindingSource;
        private ВидеоПрокатDataSetTableAdapters.КассетыTableAdapter кассетыTableAdapter;
        private ВидеоПрокатDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator кассетыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton кассетыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox наименование_фильмаTextBox;
        private System.Windows.Forms.DateTimePicker год_созданиеDateTimePicker;
        private System.Windows.Forms.TextBox производительTextBox;
        private System.Windows.Forms.TextBox странаTextBox;
        private System.Windows.Forms.TextBox главный_актёрTextBox;
        private System.Windows.Forms.DateTimePicker дата_записиDateTimePicker;
        private System.Windows.Forms.TextBox код_жанраTextBox;
        private System.Windows.Forms.TextBox ценаTextBox;
    }
}