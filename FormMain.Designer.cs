namespace GetOrderInfo
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTokenId = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.remoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSendGETRequest = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.bSaveLogPass = new System.Windows.Forms.Button();
            this.cbOrderId = new System.Windows.Forms.ComboBox();
            this.cmenuCopy2Clpbrd = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.shkFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.копироватьСеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNoClosedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGETRequset = new System.Windows.Forms.TextBox();
            this.cbOnlyBad = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKomplekt = new System.Windows.Forms.TabPage();
            this.lRecCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabInfoKorob = new System.Windows.Forms.TabPage();
            this.labelProcess = new System.Windows.Forms.Label();
            this.PalCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gridInfo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStripMain.SuspendLayout();
            this.cmenuCopy2Clpbrd.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabKomplekt.SuspendLayout();
            this.tabInfoKorob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslTokenId,
            this.toolStripDropDownButton1});
            this.statusStripMain.Location = new System.Drawing.Point(0, 602);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(594, 24);
            this.statusStripMain.TabIndex = 4;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 19);
            this.toolStripStatusLabel1.Text = "tokenId:";
            // 
            // tsslTokenId
            // 
            this.tsslTokenId.AutoSize = false;
            this.tsslTokenId.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslTokenId.Name = "tsslTokenId";
            this.tsslTokenId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsslTokenId.Size = new System.Drawing.Size(228, 19);
            this.tsslTokenId.Text = "-none-";
            this.tsslTokenId.Click += new System.EventHandler(this.tsslTokenId_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteToolStripMenuItem,
            this.localToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(100, 22);
            this.toolStripDropDownButton1.Text = "локальный";
            this.toolStripDropDownButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDropDownButton1.ToolTipText = "локально";
            // 
            // remoteToolStripMenuItem
            // 
            this.remoteToolStripMenuItem.Name = "remoteToolStripMenuItem";
            this.remoteToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.remoteToolStripMenuItem.Text = "локальный";
            this.remoteToolStripMenuItem.Click += new System.EventHandler(this.remoteToolStripMenuItem_Click);
            // 
            // localToolStripMenuItem
            // 
            this.localToolStripMenuItem.Name = "localToolStripMenuItem";
            this.localToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.localToolStripMenuItem.Text = "удаленный";
            this.localToolStripMenuItem.Click += new System.EventHandler(this.localToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID:";
            // 
            // buttonSendGETRequest
            // 
            this.buttonSendGETRequest.Location = new System.Drawing.Point(114, 4);
            this.buttonSendGETRequest.Name = "buttonSendGETRequest";
            this.buttonSendGETRequest.Size = new System.Drawing.Size(136, 23);
            this.buttonSendGETRequest.TabIndex = 2;
            this.buttonSendGETRequest.Text = "статус комплектации";
            this.buttonSendGETRequest.UseVisualStyleBackColor = true;
            this.buttonSendGETRequest.Click += new System.EventHandler(this.buttonSendGETRequest_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 448);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "nc";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "тип";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "закрыт";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "wmscode";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 182;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "grpcode";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 166;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Пользователь:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль:";
            // 
            // textLogin
            // 
            this.textLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textLogin.Enabled = false;
            this.textLogin.Location = new System.Drawing.Point(142, 578);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(81, 20);
            this.textLogin.TabIndex = 5;
            this.textLogin.Text = "login";
            // 
            // textPassword
            // 
            this.textPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textPassword.Enabled = false;
            this.textPassword.Location = new System.Drawing.Point(283, 578);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(87, 20);
            this.textPassword.TabIndex = 6;
            this.textPassword.Text = "password";
            // 
            // bSaveLogPass
            // 
            this.bSaveLogPass.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSaveLogPass.Location = new System.Drawing.Point(380, 576);
            this.bSaveLogPass.Name = "bSaveLogPass";
            this.bSaveLogPass.Size = new System.Drawing.Size(75, 23);
            this.bSaveLogPass.TabIndex = 7;
            this.bSaveLogPass.Text = "Изменить";
            this.bSaveLogPass.UseVisualStyleBackColor = true;
            this.bSaveLogPass.Click += new System.EventHandler(this.bSaveLogPass_Click);
            // 
            // cbOrderId
            // 
            this.cbOrderId.FormattingEnabled = true;
            this.cbOrderId.Location = new System.Drawing.Point(33, 6);
            this.cbOrderId.Name = "cbOrderId";
            this.cbOrderId.Size = new System.Drawing.Size(69, 21);
            this.cbOrderId.Sorted = true;
            this.cbOrderId.TabIndex = 1;
            this.cbOrderId.Text = "783463";
            this.cbOrderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOrderId_KeyPress);
            // 
            // cmenuCopy2Clpbrd
            // 
            this.cmenuCopy2Clpbrd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shkFormToolStripMenuItem,
            this.toolStripMenuItem2,
            this.копироватьСеToolStripMenuItem,
            this.copySelectedToolStripMenuItem,
            this.copyNoClosedToolStripMenuItem});
            this.cmenuCopy2Clpbrd.Name = "cmenuCopy2Clpbrd";
            this.cmenuCopy2Clpbrd.Size = new System.Drawing.Size(256, 98);
            this.cmenuCopy2Clpbrd.Text = "Копировать wmscode";
            // 
            // shkFormToolStripMenuItem
            // 
            this.shkFormToolStripMenuItem.Name = "shkFormToolStripMenuItem";
            this.shkFormToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.shkFormToolStripMenuItem.Text = "штрих код ячейки под курсором";
            this.shkFormToolStripMenuItem.Click += new System.EventHandler(this.shkFormToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(252, 6);
            // 
            // копироватьСеToolStripMenuItem
            // 
            this.копироватьСеToolStripMenuItem.Name = "копироватьСеToolStripMenuItem";
            this.копироватьСеToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.копироватьСеToolStripMenuItem.Text = "копировать все";
            this.копироватьСеToolStripMenuItem.Click += new System.EventHandler(this.копироватьСеToolStripMenuItem_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.copySelectedToolStripMenuItem.Text = "копировать выбранное";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // copyNoClosedToolStripMenuItem
            // 
            this.copyNoClosedToolStripMenuItem.Name = "copyNoClosedToolStripMenuItem";
            this.copyNoClosedToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.copyNoClosedToolStripMenuItem.Text = "копировать не закрытые";
            this.copyNoClosedToolStripMenuItem.Click += new System.EventHandler(this.copyNoClosedToolStripMenuItem_Click);
            // 
            // editGETRequset
            // 
            this.editGETRequset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editGETRequset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editGETRequset.Location = new System.Drawing.Point(12, 33);
            this.editGETRequset.Name = "editGETRequset";
            this.editGETRequset.ReadOnly = true;
            this.editGETRequset.Size = new System.Drawing.Size(570, 18);
            this.editGETRequset.TabIndex = 14;
            this.editGETRequset.Text = "http://109.73.38.93:61079/api/tss/assembly-order/";
            // 
            // cbOnlyBad
            // 
            this.cbOnlyBad.AutoSize = true;
            this.cbOnlyBad.Location = new System.Drawing.Point(6, 6);
            this.cbOnlyBad.Name = "cbOnlyBad";
            this.cbOnlyBad.Size = new System.Drawing.Size(130, 17);
            this.cbOnlyBad.TabIndex = 15;
            this.cbOnlyBad.Text = "только не закрытые";
            this.cbOnlyBad.UseVisualStyleBackColor = true;
            this.cbOnlyBad.CheckedChanged += new System.EventHandler(this.cbOnlyBad_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "До короба";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabKomplekt);
            this.tabControl1.Controls.Add(this.tabInfoKorob);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 505);
            this.tabControl1.TabIndex = 18;
            // 
            // tabKomplekt
            // 
            this.tabKomplekt.Controls.Add(this.lRecCount);
            this.tabKomplekt.Controls.Add(this.label4);
            this.tabKomplekt.Controls.Add(this.cbOnlyBad);
            this.tabKomplekt.Controls.Add(this.listView1);
            this.tabKomplekt.Location = new System.Drawing.Point(4, 22);
            this.tabKomplekt.Name = "tabKomplekt";
            this.tabKomplekt.Padding = new System.Windows.Forms.Padding(3);
            this.tabKomplekt.Size = new System.Drawing.Size(562, 479);
            this.tabKomplekt.TabIndex = 0;
            this.tabKomplekt.Text = "Комплектация";
            this.tabKomplekt.UseVisualStyleBackColor = true;
            // 
            // lRecCount
            // 
            this.lRecCount.AutoSize = true;
            this.lRecCount.Location = new System.Drawing.Point(517, 6);
            this.lRecCount.Name = "lRecCount";
            this.lRecCount.Size = new System.Drawing.Size(10, 13);
            this.lRecCount.TabIndex = 17;
            this.lRecCount.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Кол-во:";
            // 
            // tabInfoKorob
            // 
            this.tabInfoKorob.Controls.Add(this.labelProcess);
            this.tabInfoKorob.Controls.Add(this.PalCount);
            this.tabInfoKorob.Controls.Add(this.label5);
            this.tabInfoKorob.Controls.Add(this.gridInfo);
            this.tabInfoKorob.Location = new System.Drawing.Point(4, 22);
            this.tabInfoKorob.Name = "tabInfoKorob";
            this.tabInfoKorob.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoKorob.Size = new System.Drawing.Size(562, 479);
            this.tabInfoKorob.TabIndex = 1;
            this.tabInfoKorob.Text = "Детализация до короба";
            this.tabInfoKorob.UseVisualStyleBackColor = true;
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProcess.ForeColor = System.Drawing.Color.Red;
            this.labelProcess.Location = new System.Drawing.Point(7, 6);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(426, 15);
            this.labelProcess.TabIndex = 19;
            this.labelProcess.Text = "-------- Запрос отправлен. Ожидание ответа от сервера --------";
            // 
            // PalCount
            // 
            this.PalCount.AutoSize = true;
            this.PalCount.Location = new System.Drawing.Point(517, 6);
            this.PalCount.Name = "PalCount";
            this.PalCount.Size = new System.Drawing.Size(10, 13);
            this.PalCount.TabIndex = 18;
            this.PalCount.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Кол-во:";
            // 
            // gridInfo
            // 
            this.gridInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridInfo.Location = new System.Drawing.Point(3, 28);
            this.gridInfo.MainView = this.gridView1;
            this.gridInfo.Name = "gridInfo";
            this.gridInfo.Size = new System.Drawing.Size(556, 448);
            this.gridInfo.TabIndex = 0;
            this.gridInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridInfo;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "child", null, "(Коробов - {0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 45;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "data_type";
            this.gridColumn2.FieldName = "data_type";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 69;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "grpcode";
            this.gridColumn3.FieldName = "grpcode";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 146;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "wmscode";
            this.gridColumn4.FieldName = "wmscode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 143;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Короб";
            this.gridColumn5.FieldName = "child";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 140;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 626);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editGETRequset);
            this.Controls.Add(this.cbOrderId);
            this.Controls.Add(this.bSaveLogPass);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSendGETRequest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(610, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GetOrderInfo by (c)Kandakov Dmitry   v 1.0.23";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.cmenuCopy2Clpbrd.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabKomplekt.ResumeLayout(false);
            this.tabKomplekt.PerformLayout();
            this.tabInfoKorob.ResumeLayout(false);
            this.tabInfoKorob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTokenId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendGETRequest;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button bSaveLogPass;
        private System.Windows.Forms.ComboBox cbOrderId;
        private System.Windows.Forms.ContextMenuStrip cmenuCopy2Clpbrd;
        private System.Windows.Forms.TextBox editGETRequset;
        private System.Windows.Forms.ToolStripMenuItem копироватьСеToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbOnlyBad;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem remoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyNoClosedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shkFormToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKomplekt;
        private System.Windows.Forms.TabPage tabInfoKorob;
        private DevExpress.XtraGrid.GridControl gridInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label lRecCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PalCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProcess;
    }
}

