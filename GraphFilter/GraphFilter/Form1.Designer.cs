﻿namespace GraphFilter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listInvResults = new System.Windows.Forms.DataGridView();
            this.ColunaInvariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.enableSome_Q_integer = new JCS.ToggleSwitch();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.enableSome_L_integer = new JCS.ToggleSwitch();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.enable_Q_integral = new JCS.ToggleSwitch();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.enableSome_A_integer = new JCS.ToggleSwitch();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.enableLarg_Q_integer = new JCS.ToggleSwitch();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.enable_L_integral = new JCS.ToggleSwitch();
            this.enable_A_integral = new JCS.ToggleSwitch();
            this.enableLarg_L_integer = new JCS.ToggleSwitch();
            this.enableLarg_A_integer = new JCS.ToggleSwitch();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.enableIsAcyclic = new JCS.ToggleSwitch();
            this.enableIsPlanar = new JCS.ToggleSwitch();
            this.enableIsHamiltonian = new JCS.ToggleSwitch();
            this.enableIsConnected = new JCS.ToggleSwitch();
            this.enableRegularWithK = new JCS.ToggleSwitch();
            this.enableRegular = new JCS.ToggleSwitch();
            this.paramRegularWithDegree = new MetroFramework.Controls.MetroTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxEq = new System.Windows.Forms.GroupBox();
            this.enableEq1 = new JCS.ToggleSwitch();
            this.verifyEq1 = new System.Windows.Forms.Button();
            this.textEquation1 = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.listOfG6 = new System.Windows.Forms.ListBox();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.buttonCounterexample = new System.Windows.Forms.Button();
            this.ListOfInvariants = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.textOutPath = new MetroFramework.Controls.MetroTextBox();
            this.textSource = new MetroFramework.Controls.MetroTextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.buttonExportTikZ = new System.Windows.Forms.Button();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.showGraphInvariantLbl = new MetroFramework.Controls.MetroLabel();
            this.showInvariantsCheck = new JCS.ToggleSwitch();
            this.openG6BtnViz = new MetroFramework.Controls.MetroButton();
            this.viewG6Btn = new MetroFramework.Controls.MetroButton();
            this.insertG6ToView = new MetroFramework.Controls.MetroTextBox();
            this.textOpenViz = new MetroFramework.Controls.MetroTextBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonZoomOriginal = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonExp2PNG = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.lblVersion = new MetroFramework.Controls.MetroLabel();
            this.chkUpdBtn = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listInvResults)).BeginInit();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxEq.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listInvResults
            // 
            this.listInvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listInvResults.BackgroundColor = System.Drawing.Color.White;
            this.listInvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listInvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listInvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaInvariant,
            this.ColunaResultado});
            this.listInvResults.Location = new System.Drawing.Point(153, 104);
            this.listInvResults.Margin = new System.Windows.Forms.Padding(2);
            this.listInvResults.MinimumSize = new System.Drawing.Size(322, 162);
            this.listInvResults.MultiSelect = false;
            this.listInvResults.Name = "listInvResults";
            this.listInvResults.RowHeadersWidth = 51;
            this.listInvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listInvResults.RowTemplate.Height = 24;
            this.listInvResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listInvResults.ShowRowErrors = false;
            this.listInvResults.Size = new System.Drawing.Size(322, 276);
            this.listInvResults.TabIndex = 0;
            this.listInvResults.Visible = false;
            this.listInvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listInvResults_CellContentClick);
            // 
            // ColunaInvariant
            // 
            this.ColunaInvariant.HeaderText = "Invariant";
            this.ColunaInvariant.MinimumWidth = 6;
            this.ColunaInvariant.Name = "ColunaInvariant";
            this.ColunaInvariant.Width = 125;
            // 
            // ColunaResultado
            // 
            this.ColunaResultado.HeaderText = "Result";
            this.ColunaResultado.MinimumWidth = 6;
            this.ColunaResultado.Name = "ColunaResultado";
            this.ColunaResultado.Width = 125;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxCondition.Controls.Add(this.metroLabel16);
            this.groupBoxCondition.Controls.Add(this.enableSome_Q_integer);
            this.groupBoxCondition.Controls.Add(this.metroLabel15);
            this.groupBoxCondition.Controls.Add(this.enableSome_L_integer);
            this.groupBoxCondition.Controls.Add(this.metroLabel14);
            this.groupBoxCondition.Controls.Add(this.enable_Q_integral);
            this.groupBoxCondition.Controls.Add(this.metroLabel13);
            this.groupBoxCondition.Controls.Add(this.metroLabel12);
            this.groupBoxCondition.Controls.Add(this.enableSome_A_integer);
            this.groupBoxCondition.Controls.Add(this.metroLabel11);
            this.groupBoxCondition.Controls.Add(this.enableLarg_Q_integer);
            this.groupBoxCondition.Controls.Add(this.metroLabel10);
            this.groupBoxCondition.Controls.Add(this.metroLabel9);
            this.groupBoxCondition.Controls.Add(this.metroLabel8);
            this.groupBoxCondition.Controls.Add(this.metroLabel7);
            this.groupBoxCondition.Controls.Add(this.enable_L_integral);
            this.groupBoxCondition.Controls.Add(this.enable_A_integral);
            this.groupBoxCondition.Controls.Add(this.enableLarg_L_integer);
            this.groupBoxCondition.Controls.Add(this.enableLarg_A_integer);
            this.groupBoxCondition.Controls.Add(this.metroLabel4);
            this.groupBoxCondition.Controls.Add(this.metroLabel5);
            this.groupBoxCondition.Controls.Add(this.metroLabel6);
            this.groupBoxCondition.Controls.Add(this.metroLabel3);
            this.groupBoxCondition.Controls.Add(this.metroLabel1);
            this.groupBoxCondition.Controls.Add(this.metroLabel2);
            this.groupBoxCondition.Controls.Add(this.enableIsAcyclic);
            this.groupBoxCondition.Controls.Add(this.enableIsPlanar);
            this.groupBoxCondition.Controls.Add(this.enableIsHamiltonian);
            this.groupBoxCondition.Controls.Add(this.enableIsConnected);
            this.groupBoxCondition.Controls.Add(this.enableRegularWithK);
            this.groupBoxCondition.Controls.Add(this.enableRegular);
            this.groupBoxCondition.Controls.Add(this.paramRegularWithDegree);
            this.groupBoxCondition.Location = new System.Drawing.Point(0, 84);
            this.groupBoxCondition.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCondition.Size = new System.Drawing.Size(463, 289);
            this.groupBoxCondition.TabIndex = 8;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Condition";
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel16.Location = new System.Drawing.Point(58, 258);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(200, 19);
            this.metroLabel16.TabIndex = 85;
            this.metroLabel16.Text = "Some eigen signless lap integer";
            // 
            // enableSome_Q_integer
            // 
            this.enableSome_Q_integer.Location = new System.Drawing.Point(8, 258);
            this.enableSome_Q_integer.Margin = new System.Windows.Forms.Padding(2);
            this.enableSome_Q_integer.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableSome_Q_integer.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableSome_Q_integer.Name = "enableSome_Q_integer";
            this.enableSome_Q_integer.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSome_Q_integer.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSome_Q_integer.Size = new System.Drawing.Size(45, 20);
            this.enableSome_Q_integer.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableSome_Q_integer.TabIndex = 84;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel15.Location = new System.Drawing.Point(58, 226);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(183, 19);
            this.metroLabel15.TabIndex = 83;
            this.metroLabel15.Text = "Some eigen laplacian integer";
            // 
            // enableSome_L_integer
            // 
            this.enableSome_L_integer.Location = new System.Drawing.Point(8, 226);
            this.enableSome_L_integer.Margin = new System.Windows.Forms.Padding(2);
            this.enableSome_L_integer.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableSome_L_integer.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableSome_L_integer.Name = "enableSome_L_integer";
            this.enableSome_L_integer.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSome_L_integer.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSome_L_integer.Size = new System.Drawing.Size(45, 20);
            this.enableSome_L_integer.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableSome_L_integer.TabIndex = 82;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(394, 193);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(73, 19);
            this.metroLabel14.TabIndex = 81;
            this.metroLabel14.Text = "Q-Integral";
            // 
            // enable_Q_integral
            // 
            this.enable_Q_integral.Location = new System.Drawing.Point(344, 193);
            this.enable_Q_integral.Margin = new System.Windows.Forms.Padding(2);
            this.enable_Q_integral.MaximumSize = new System.Drawing.Size(45, 20);
            this.enable_Q_integral.MinimumSize = new System.Drawing.Size(45, 20);
            this.enable_Q_integral.Name = "enable_Q_integral";
            this.enable_Q_integral.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_Q_integral.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_Q_integral.Size = new System.Drawing.Size(45, 20);
            this.enable_Q_integral.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enable_Q_integral.TabIndex = 79;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(58, 193);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(190, 19);
            this.metroLabel13.TabIndex = 78;
            this.metroLabel13.Text = "Some eigen adjacency integer";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(58, 161);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(211, 19);
            this.metroLabel12.TabIndex = 77;
            this.metroLabel12.Text = "Largest eigen signless lap integer";
            // 
            // enableSome_A_integer
            // 
            this.enableSome_A_integer.Location = new System.Drawing.Point(8, 193);
            this.enableSome_A_integer.Margin = new System.Windows.Forms.Padding(2);
            this.enableSome_A_integer.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableSome_A_integer.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableSome_A_integer.Name = "enableSome_A_integer";
            this.enableSome_A_integer.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSome_A_integer.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableSome_A_integer.Size = new System.Drawing.Size(45, 20);
            this.enableSome_A_integer.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableSome_A_integer.TabIndex = 76;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(58, 194);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(0, 0);
            this.metroLabel11.TabIndex = 75;
            // 
            // enableLarg_Q_integer
            // 
            this.enableLarg_Q_integer.Location = new System.Drawing.Point(8, 161);
            this.enableLarg_Q_integer.Margin = new System.Windows.Forms.Padding(2);
            this.enableLarg_Q_integer.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableLarg_Q_integer.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableLarg_Q_integer.Name = "enableLarg_Q_integer";
            this.enableLarg_Q_integer.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLarg_Q_integer.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLarg_Q_integer.Size = new System.Drawing.Size(45, 20);
            this.enableLarg_Q_integer.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableLarg_Q_integer.TabIndex = 74;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(394, 161);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(69, 19);
            this.metroLabel10.TabIndex = 73;
            this.metroLabel10.Text = "L-Integral";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(394, 128);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 19);
            this.metroLabel9.TabIndex = 72;
            this.metroLabel9.Text = "A-Integral";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(58, 128);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(194, 19);
            this.metroLabel8.TabIndex = 71;
            this.metroLabel8.Text = "Largest eigen laplacian integer";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(58, 93);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(201, 19);
            this.metroLabel7.TabIndex = 70;
            this.metroLabel7.Text = "Largest eigen adjacency integer";
            // 
            // enable_L_integral
            // 
            this.enable_L_integral.Location = new System.Drawing.Point(344, 161);
            this.enable_L_integral.Margin = new System.Windows.Forms.Padding(2);
            this.enable_L_integral.MaximumSize = new System.Drawing.Size(45, 20);
            this.enable_L_integral.MinimumSize = new System.Drawing.Size(45, 20);
            this.enable_L_integral.Name = "enable_L_integral";
            this.enable_L_integral.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_L_integral.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_L_integral.Size = new System.Drawing.Size(45, 20);
            this.enable_L_integral.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enable_L_integral.TabIndex = 69;
            this.enable_L_integral.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.enableLintegral_CheckedChanged);
            // 
            // enable_A_integral
            // 
            this.enable_A_integral.Location = new System.Drawing.Point(344, 128);
            this.enable_A_integral.Margin = new System.Windows.Forms.Padding(2);
            this.enable_A_integral.MaximumSize = new System.Drawing.Size(45, 20);
            this.enable_A_integral.MinimumSize = new System.Drawing.Size(45, 20);
            this.enable_A_integral.Name = "enable_A_integral";
            this.enable_A_integral.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_A_integral.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable_A_integral.Size = new System.Drawing.Size(45, 20);
            this.enable_A_integral.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enable_A_integral.TabIndex = 68;
            // 
            // enableLarg_L_integer
            // 
            this.enableLarg_L_integer.Location = new System.Drawing.Point(8, 128);
            this.enableLarg_L_integer.Margin = new System.Windows.Forms.Padding(2);
            this.enableLarg_L_integer.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableLarg_L_integer.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableLarg_L_integer.Name = "enableLarg_L_integer";
            this.enableLarg_L_integer.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLarg_L_integer.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLarg_L_integer.Size = new System.Drawing.Size(45, 20);
            this.enableLarg_L_integer.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableLarg_L_integer.TabIndex = 67;
            // 
            // enableLarg_A_integer
            // 
            this.enableLarg_A_integer.Location = new System.Drawing.Point(8, 94);
            this.enableLarg_A_integer.Margin = new System.Windows.Forms.Padding(2);
            this.enableLarg_A_integer.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableLarg_A_integer.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableLarg_A_integer.Name = "enableLarg_A_integer";
            this.enableLarg_A_integer.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLarg_A_integer.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableLarg_A_integer.Size = new System.Drawing.Size(45, 20);
            this.enableLarg_A_integer.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableLarg_A_integer.TabIndex = 66;
            this.enableLarg_A_integer.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.enableLargAinteger_CheckedChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(394, 93);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 65;
            this.metroLabel4.Text = "Acyclic";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(394, 59);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 64;
            this.metroLabel5.Text = "Planar";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(394, 27);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 63;
            this.metroLabel6.Text = "Hamiltonian";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(394, 226);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 62;
            this.metroLabel3.Text = "Connected";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(58, 59);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(119, 19);
            this.metroLabel1.TabIndex = 61;
            this.metroLabel1.Text = "k-regular, with k=";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(58, 27);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "Regular";
            // 
            // enableIsAcyclic
            // 
            this.enableIsAcyclic.Location = new System.Drawing.Point(344, 94);
            this.enableIsAcyclic.Margin = new System.Windows.Forms.Padding(2);
            this.enableIsAcyclic.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableIsAcyclic.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableIsAcyclic.Name = "enableIsAcyclic";
            this.enableIsAcyclic.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsAcyclic.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsAcyclic.Size = new System.Drawing.Size(45, 20);
            this.enableIsAcyclic.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableIsAcyclic.TabIndex = 58;
            // 
            // enableIsPlanar
            // 
            this.enableIsPlanar.Location = new System.Drawing.Point(344, 61);
            this.enableIsPlanar.Margin = new System.Windows.Forms.Padding(2);
            this.enableIsPlanar.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableIsPlanar.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableIsPlanar.Name = "enableIsPlanar";
            this.enableIsPlanar.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsPlanar.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsPlanar.Size = new System.Drawing.Size(45, 20);
            this.enableIsPlanar.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableIsPlanar.TabIndex = 57;
            // 
            // enableIsHamiltonian
            // 
            this.enableIsHamiltonian.Location = new System.Drawing.Point(344, 28);
            this.enableIsHamiltonian.Margin = new System.Windows.Forms.Padding(2);
            this.enableIsHamiltonian.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableIsHamiltonian.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableIsHamiltonian.Name = "enableIsHamiltonian";
            this.enableIsHamiltonian.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsHamiltonian.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsHamiltonian.Size = new System.Drawing.Size(45, 20);
            this.enableIsHamiltonian.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableIsHamiltonian.TabIndex = 56;
            // 
            // enableIsConnected
            // 
            this.enableIsConnected.Location = new System.Drawing.Point(344, 226);
            this.enableIsConnected.Margin = new System.Windows.Forms.Padding(2);
            this.enableIsConnected.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableIsConnected.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableIsConnected.Name = "enableIsConnected";
            this.enableIsConnected.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsConnected.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableIsConnected.Size = new System.Drawing.Size(45, 20);
            this.enableIsConnected.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableIsConnected.TabIndex = 55;
            // 
            // enableRegularWithK
            // 
            this.enableRegularWithK.Location = new System.Drawing.Point(8, 60);
            this.enableRegularWithK.Margin = new System.Windows.Forms.Padding(2);
            this.enableRegularWithK.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableRegularWithK.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableRegularWithK.Name = "enableRegularWithK";
            this.enableRegularWithK.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableRegularWithK.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableRegularWithK.Size = new System.Drawing.Size(45, 20);
            this.enableRegularWithK.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableRegularWithK.TabIndex = 54;
            this.enableRegularWithK.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.enableRegularWithK_CheckedChanged_1);
            // 
            // enableRegular
            // 
            this.enableRegular.Location = new System.Drawing.Point(8, 28);
            this.enableRegular.Margin = new System.Windows.Forms.Padding(2);
            this.enableRegular.MaximumSize = new System.Drawing.Size(45, 20);
            this.enableRegular.MinimumSize = new System.Drawing.Size(45, 20);
            this.enableRegular.Name = "enableRegular";
            this.enableRegular.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableRegular.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableRegular.Size = new System.Drawing.Size(45, 20);
            this.enableRegular.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableRegular.TabIndex = 53;
            this.enableRegular.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.enableRegular_CheckedChanged_2);
            // 
            // paramRegularWithDegree
            // 
            // 
            // 
            // 
            this.paramRegularWithDegree.CustomButton.Image = null;
            this.paramRegularWithDegree.CustomButton.Location = new System.Drawing.Point(10, 1);
            this.paramRegularWithDegree.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.paramRegularWithDegree.CustomButton.Name = "";
            this.paramRegularWithDegree.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.paramRegularWithDegree.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.paramRegularWithDegree.CustomButton.TabIndex = 1;
            this.paramRegularWithDegree.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paramRegularWithDegree.CustomButton.UseSelectable = true;
            this.paramRegularWithDegree.CustomButton.Visible = false;
            this.paramRegularWithDegree.Enabled = false;
            this.paramRegularWithDegree.Lines = new string[0];
            this.paramRegularWithDegree.Location = new System.Drawing.Point(181, 59);
            this.paramRegularWithDegree.Margin = new System.Windows.Forms.Padding(2);
            this.paramRegularWithDegree.MaxLength = 32767;
            this.paramRegularWithDegree.Name = "paramRegularWithDegree";
            this.paramRegularWithDegree.PasswordChar = '\0';
            this.paramRegularWithDegree.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.paramRegularWithDegree.SelectedText = "";
            this.paramRegularWithDegree.SelectionLength = 0;
            this.paramRegularWithDegree.SelectionStart = 0;
            this.paramRegularWithDegree.ShortcutsEnabled = true;
            this.paramRegularWithDegree.Size = new System.Drawing.Size(28, 19);
            this.paramRegularWithDegree.TabIndex = 50;
            this.paramRegularWithDegree.UseSelectable = true;
            this.paramRegularWithDegree.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.paramRegularWithDegree.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.paramRegularWithDegree.Click += new System.EventHandler(this.paramRegularWithDegree_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(4, 47);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 24);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Output .g6 File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(0, 478);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(153, 32);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Filter the list";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.EnabledChanged += new System.EventHandler(this.buttonSearch_EnabledChanged);
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // groupBoxEq
            // 
            this.groupBoxEq.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxEq.Controls.Add(this.enableEq1);
            this.groupBoxEq.Controls.Add(this.verifyEq1);
            this.groupBoxEq.Controls.Add(this.textEquation1);
            this.groupBoxEq.Controls.Add(this.label6);
            this.groupBoxEq.Location = new System.Drawing.Point(0, 376);
            this.groupBoxEq.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEq.Name = "groupBoxEq";
            this.groupBoxEq.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEq.Size = new System.Drawing.Size(439, 96);
            this.groupBoxEq.TabIndex = 7;
            this.groupBoxEq.TabStop = false;
            this.groupBoxEq.Text = "Equations";
            // 
            // enableEq1
            // 
            this.enableEq1.Location = new System.Drawing.Point(8, 46);
            this.enableEq1.Margin = new System.Windows.Forms.Padding(2);
            this.enableEq1.Name = "enableEq1";
            this.enableEq1.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableEq1.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableEq1.Size = new System.Drawing.Size(38, 20);
            this.enableEq1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.enableEq1.TabIndex = 53;
            this.enableEq1.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.EnableEq1_CheckedChanged);
            // 
            // verifyEq1
            // 
            this.verifyEq1.Enabled = false;
            this.verifyEq1.FlatAppearance.BorderSize = 0;
            this.verifyEq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyEq1.Image = global::GraphFilter.Properties.Resources.icons8_checked_checkbox;
            this.verifyEq1.Location = new System.Drawing.Point(49, 40);
            this.verifyEq1.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq1.MaximumSize = new System.Drawing.Size(27, 29);
            this.verifyEq1.MinimumSize = new System.Drawing.Size(27, 29);
            this.verifyEq1.Name = "verifyEq1";
            this.verifyEq1.Size = new System.Drawing.Size(27, 29);
            this.verifyEq1.TabIndex = 0;
            this.verifyEq1.UseVisualStyleBackColor = true;
            this.verifyEq1.Click += new System.EventHandler(this.verifyEq1_Click);
            // 
            // textEquation1
            // 
            // 
            // 
            // 
            this.textEquation1.CustomButton.Image = null;
            this.textEquation1.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.textEquation1.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.textEquation1.CustomButton.Name = "";
            this.textEquation1.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.textEquation1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEquation1.CustomButton.TabIndex = 1;
            this.textEquation1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEquation1.CustomButton.UseSelectable = true;
            this.textEquation1.CustomButton.Visible = false;
            this.textEquation1.Enabled = false;
            this.textEquation1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textEquation1.Lines = new string[0];
            this.textEquation1.Location = new System.Drawing.Point(78, 24);
            this.textEquation1.Margin = new System.Windows.Forms.Padding(2);
            this.textEquation1.MaxLength = 32767;
            this.textEquation1.Multiline = true;
            this.textEquation1.Name = "textEquation1";
            this.textEquation1.PasswordChar = '\0';
            this.textEquation1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEquation1.SelectedText = "";
            this.textEquation1.SelectionLength = 0;
            this.textEquation1.SelectionStart = 0;
            this.textEquation1.ShortcutsEnabled = true;
            this.textEquation1.Size = new System.Drawing.Size(356, 61);
            this.textEquation1.TabIndex = 1;
            this.textEquation1.UseSelectable = true;
            this.textEquation1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEquation1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // wpfHost
            // 
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(154, 70);
            this.wpfHost.Margin = new System.Windows.Forms.Padding(2);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(482, 315);
            this.wpfHost.TabIndex = 52;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.wpfHost_ChildChanged);
            this.wpfHost.Child = null;
            // 
            // listOfG6
            // 
            this.listOfG6.FormattingEnabled = true;
            this.listOfG6.HorizontalScrollbar = true;
            this.listOfG6.Location = new System.Drawing.Point(4, 109);
            this.listOfG6.Margin = new System.Windows.Forms.Padding(2);
            this.listOfG6.Name = "listOfG6";
            this.listOfG6.Size = new System.Drawing.Size(146, 277);
            this.listOfG6.TabIndex = 0;
            this.listOfG6.Visible = false;
            this.listOfG6.SelectedIndexChanged += new System.EventHandler(this.listOfG6_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabControl.Location = new System.Drawing.Point(17, 58);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(958, 581);
            this.tabControl.TabIndex = 52;
            this.tabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.buttonCounterexample);
            this.metroTabPage1.Controls.Add(this.ListOfInvariants);
            this.metroTabPage1.Controls.Add(this.progressBar);
            this.metroTabPage1.Controls.Add(this.groupBoxFiles);
            this.metroTabPage1.Controls.Add(this.groupBoxCondition);
            this.metroTabPage1.Controls.Add(this.buttonSearch);
            this.metroTabPage1.Controls.Add(this.groupBoxEq);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 8;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(950, 540);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Filter Graphs";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 8;
            // 
            // buttonCounterexample
            // 
            this.buttonCounterexample.Enabled = false;
            this.buttonCounterexample.Location = new System.Drawing.Point(260, 478);
            this.buttonCounterexample.Name = "buttonCounterexample";
            this.buttonCounterexample.Size = new System.Drawing.Size(202, 32);
            this.buttonCounterexample.TabIndex = 53;
            this.buttonCounterexample.Text = "Is there a counterexample?";
            this.buttonCounterexample.UseVisualStyleBackColor = true;
            this.buttonCounterexample.Click += new System.EventHandler(this.buttonCounterexample_Click);
            // 
            // ListOfInvariants
            // 
            this.ListOfInvariants.AutoSize = true;
            this.ListOfInvariants.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListOfInvariants.Location = new System.Drawing.Point(808, 0);
            this.ListOfInvariants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ListOfInvariants.Name = "ListOfInvariants";
            this.ListOfInvariants.Size = new System.Drawing.Size(142, 19);
            this.ListOfInvariants.TabIndex = 2;
            this.ListOfInvariants.Text = "Dictionary of invariants";
            this.ListOfInvariants.Click += new System.EventHandler(this.ListOfInvariants_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 514);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(440, 32);
            this.progressBar.TabIndex = 52;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFiles.Controls.Add(this.textOutPath);
            this.groupBoxFiles.Controls.Add(this.textSource);
            this.groupBoxFiles.Controls.Add(this.buttonOpen);
            this.groupBoxFiles.Controls.Add(this.buttonSave);
            this.groupBoxFiles.Location = new System.Drawing.Point(0, 2);
            this.groupBoxFiles.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFiles.Size = new System.Drawing.Size(439, 81);
            this.groupBoxFiles.TabIndex = 1;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // textOutPath
            // 
            // 
            // 
            // 
            this.textOutPath.CustomButton.Image = null;
            this.textOutPath.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.textOutPath.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.textOutPath.CustomButton.Name = "";
            this.textOutPath.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.textOutPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOutPath.CustomButton.TabIndex = 1;
            this.textOutPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOutPath.CustomButton.UseSelectable = true;
            this.textOutPath.CustomButton.Visible = false;
            this.textOutPath.Enabled = false;
            this.textOutPath.Lines = new string[0];
            this.textOutPath.Location = new System.Drawing.Point(113, 50);
            this.textOutPath.Margin = new System.Windows.Forms.Padding(2);
            this.textOutPath.MaxLength = 32767;
            this.textOutPath.Name = "textOutPath";
            this.textOutPath.PasswordChar = '\0';
            this.textOutPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOutPath.SelectedText = "";
            this.textOutPath.SelectionLength = 0;
            this.textOutPath.SelectionStart = 0;
            this.textOutPath.ShortcutsEnabled = true;
            this.textOutPath.Size = new System.Drawing.Size(320, 19);
            this.textOutPath.TabIndex = 53;
            this.textOutPath.UseSelectable = true;
            this.textOutPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOutPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textSource
            // 
            // 
            // 
            // 
            this.textSource.CustomButton.Image = null;
            this.textSource.CustomButton.Location = new System.Drawing.Point(302, 1);
            this.textSource.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.textSource.CustomButton.Name = "";
            this.textSource.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.textSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSource.CustomButton.TabIndex = 1;
            this.textSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSource.CustomButton.UseSelectable = true;
            this.textSource.CustomButton.Visible = false;
            this.textSource.Enabled = false;
            this.textSource.Lines = new string[0];
            this.textSource.Location = new System.Drawing.Point(113, 22);
            this.textSource.Margin = new System.Windows.Forms.Padding(2);
            this.textSource.MaxLength = 32767;
            this.textSource.Name = "textSource";
            this.textSource.PasswordChar = '\0';
            this.textSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSource.SelectedText = "";
            this.textSource.SelectionLength = 0;
            this.textSource.SelectionStart = 0;
            this.textSource.ShortcutsEnabled = true;
            this.textSource.Size = new System.Drawing.Size(320, 19);
            this.textSource.TabIndex = 52;
            this.textSource.UseSelectable = true;
            this.textSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(4, 16);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(104, 24);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open .g6 File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.buttonExportTikZ);
            this.metroTabPage2.Controls.Add(this.metroProgressSpinner);
            this.metroTabPage2.Controls.Add(this.buttonExportAll);
            this.metroTabPage2.Controls.Add(this.listInvResults);
            this.metroTabPage2.Controls.Add(this.showGraphInvariantLbl);
            this.metroTabPage2.Controls.Add(this.showInvariantsCheck);
            this.metroTabPage2.Controls.Add(this.openG6BtnViz);
            this.metroTabPage2.Controls.Add(this.viewG6Btn);
            this.metroTabPage2.Controls.Add(this.insertG6ToView);
            this.metroTabPage2.Controls.Add(this.textOpenViz);
            this.metroTabPage2.Controls.Add(this.buttonFill);
            this.metroTabPage2.Controls.Add(this.buttonZoomOriginal);
            this.metroTabPage2.Controls.Add(this.buttonZoomOut);
            this.metroTabPage2.Controls.Add(this.buttonZoomIn);
            this.metroTabPage2.Controls.Add(this.buttonExp2PNG);
            this.metroTabPage2.Controls.Add(this.buttonPrint);
            this.metroTabPage2.Controls.Add(this.wpfHost);
            this.metroTabPage2.Controls.Add(this.listOfG6);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 8;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(950, 540);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Visualization";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 8;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // buttonExportTikZ
            // 
            this.buttonExportTikZ.BackColor = System.Drawing.Color.White;
            this.buttonExportTikZ.Enabled = false;
            this.buttonExportTikZ.FlatAppearance.BorderSize = 0;
            this.buttonExportTikZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportTikZ.Image = global::GraphFilter.Properties.Resources.Tikz32;
            this.buttonExportTikZ.Location = new System.Drawing.Point(230, 61);
            this.buttonExportTikZ.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExportTikZ.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonExportTikZ.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonExportTikZ.Name = "buttonExportTikZ";
            this.buttonExportTikZ.Size = new System.Drawing.Size(38, 41);
            this.buttonExportTikZ.TabIndex = 65;
            this.buttonExportTikZ.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonExportTikZ.UseVisualStyleBackColor = false;
            this.buttonExportTikZ.Click += new System.EventHandler(this.buttonExportTikZ_Click);
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressSpinner.Location = new System.Drawing.Point(390, 165);
            this.metroProgressSpinner.Margin = new System.Windows.Forms.Padding(0);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.MaximumSize = new System.Drawing.Size(220, 220);
            this.metroProgressSpinner.MinimumSize = new System.Drawing.Size(220, 220);
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(220, 220);
            this.metroProgressSpinner.Speed = 3F;
            this.metroProgressSpinner.TabIndex = 64;
            this.metroProgressSpinner.UseSelectable = true;
            this.metroProgressSpinner.Visible = false;
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.BackColor = System.Drawing.Color.White;
            this.buttonExportAll.Enabled = false;
            this.buttonExportAll.FlatAppearance.BorderSize = 0;
            this.buttonExportAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportAll.Image = global::GraphFilter.Properties.Resources.ExportAllPNG32;
            this.buttonExportAll.Location = new System.Drawing.Point(192, 61);
            this.buttonExportAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExportAll.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonExportAll.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(38, 41);
            this.buttonExportAll.TabIndex = 63;
            this.buttonExportAll.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonExportAll.UseVisualStyleBackColor = false;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // showGraphInvariantLbl
            // 
            this.showGraphInvariantLbl.AutoSize = true;
            this.showGraphInvariantLbl.Location = new System.Drawing.Point(840, 61);
            this.showGraphInvariantLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showGraphInvariantLbl.Name = "showGraphInvariantLbl";
            this.showGraphInvariantLbl.Size = new System.Drawing.Size(138, 19);
            this.showGraphInvariantLbl.TabIndex = 62;
            this.showGraphInvariantLbl.Text = "Show Graph Invariants";
            this.showGraphInvariantLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showInvariantsCheck
            // 
            this.showInvariantsCheck.Location = new System.Drawing.Point(798, 65);
            this.showInvariantsCheck.Margin = new System.Windows.Forms.Padding(2);
            this.showInvariantsCheck.Name = "showInvariantsCheck";
            this.showInvariantsCheck.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInvariantsCheck.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showInvariantsCheck.Size = new System.Drawing.Size(38, 20);
            this.showInvariantsCheck.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            this.showInvariantsCheck.TabIndex = 61;
            this.showInvariantsCheck.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.showInvariantsCheck_CheckedChanged);
            // 
            // openG6BtnViz
            // 
            this.openG6BtnViz.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.openG6BtnViz.Location = new System.Drawing.Point(4, 37);
            this.openG6BtnViz.Margin = new System.Windows.Forms.Padding(2);
            this.openG6BtnViz.MaximumSize = new System.Drawing.Size(112, 20);
            this.openG6BtnViz.MinimumSize = new System.Drawing.Size(112, 20);
            this.openG6BtnViz.Name = "openG6BtnViz";
            this.openG6BtnViz.Size = new System.Drawing.Size(112, 20);
            this.openG6BtnViz.TabIndex = 60;
            this.openG6BtnViz.Text = "Open .g6 File";
            this.openG6BtnViz.UseSelectable = true;
            this.openG6BtnViz.Click += new System.EventHandler(this.openG6BtnViz_Click);
            // 
            // viewG6Btn
            // 
            this.viewG6Btn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.viewG6Btn.Location = new System.Drawing.Point(4, 14);
            this.viewG6Btn.Margin = new System.Windows.Forms.Padding(2);
            this.viewG6Btn.MaximumSize = new System.Drawing.Size(112, 20);
            this.viewG6Btn.MinimumSize = new System.Drawing.Size(112, 20);
            this.viewG6Btn.Name = "viewG6Btn";
            this.viewG6Btn.Size = new System.Drawing.Size(112, 20);
            this.viewG6Btn.TabIndex = 59;
            this.viewG6Btn.Text = "View Graph";
            this.viewG6Btn.UseSelectable = true;
            this.viewG6Btn.Click += new System.EventHandler(this.viewG6Btn_Click);
            // 
            // insertG6ToView
            // 
            // 
            // 
            // 
            this.insertG6ToView.CustomButton.Image = null;
            this.insertG6ToView.CustomButton.Location = new System.Drawing.Point(811, 2);
            this.insertG6ToView.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.insertG6ToView.CustomButton.Name = "";
            this.insertG6ToView.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.insertG6ToView.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.insertG6ToView.CustomButton.TabIndex = 1;
            this.insertG6ToView.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.insertG6ToView.CustomButton.UseSelectable = true;
            this.insertG6ToView.CustomButton.Visible = false;
            this.insertG6ToView.Lines = new string[0];
            this.insertG6ToView.Location = new System.Drawing.Point(121, 14);
            this.insertG6ToView.Margin = new System.Windows.Forms.Padding(2);
            this.insertG6ToView.MaxLength = 32767;
            this.insertG6ToView.Name = "insertG6ToView";
            this.insertG6ToView.PasswordChar = '\0';
            this.insertG6ToView.PromptText = "Type a g6 code here!";
            this.insertG6ToView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.insertG6ToView.SelectedText = "";
            this.insertG6ToView.SelectionLength = 0;
            this.insertG6ToView.SelectionStart = 0;
            this.insertG6ToView.ShortcutsEnabled = true;
            this.insertG6ToView.Size = new System.Drawing.Size(829, 20);
            this.insertG6ToView.TabIndex = 58;
            this.insertG6ToView.UseSelectable = true;
            this.insertG6ToView.WaterMark = "Type a g6 code here!";
            this.insertG6ToView.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.insertG6ToView.WaterMarkFont = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertG6ToView.Click += new System.EventHandler(this.insertG6ToView_Click);
            // 
            // textOpenViz
            // 
            // 
            // 
            // 
            this.textOpenViz.CustomButton.Image = null;
            this.textOpenViz.CustomButton.Location = new System.Drawing.Point(812, 2);
            this.textOpenViz.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.textOpenViz.CustomButton.Name = "";
            this.textOpenViz.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.textOpenViz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOpenViz.CustomButton.TabIndex = 1;
            this.textOpenViz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOpenViz.CustomButton.UseSelectable = true;
            this.textOpenViz.CustomButton.Visible = false;
            this.textOpenViz.Enabled = false;
            this.textOpenViz.Lines = new string[0];
            this.textOpenViz.Location = new System.Drawing.Point(121, 37);
            this.textOpenViz.Margin = new System.Windows.Forms.Padding(2);
            this.textOpenViz.MaxLength = 32767;
            this.textOpenViz.Name = "textOpenViz";
            this.textOpenViz.PasswordChar = '\0';
            this.textOpenViz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOpenViz.SelectedText = "";
            this.textOpenViz.SelectionLength = 0;
            this.textOpenViz.SelectionStart = 0;
            this.textOpenViz.ShortcutsEnabled = true;
            this.textOpenViz.Size = new System.Drawing.Size(830, 20);
            this.textOpenViz.TabIndex = 56;
            this.textOpenViz.UseSelectable = true;
            this.textOpenViz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOpenViz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonFill
            // 
            this.buttonFill.BackColor = System.Drawing.Color.White;
            this.buttonFill.FlatAppearance.BorderSize = 0;
            this.buttonFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFill.Image = global::GraphFilter.Properties.Resources.icons8_zoom_to_extents_2;
            this.buttonFill.Location = new System.Drawing.Point(4, 61);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFill.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonFill.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(38, 41);
            this.buttonFill.TabIndex = 53;
            this.buttonFill.UseVisualStyleBackColor = false;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonZoomOriginal
            // 
            this.buttonZoomOriginal.BackColor = System.Drawing.Color.White;
            this.buttonZoomOriginal.FlatAppearance.BorderSize = 0;
            this.buttonZoomOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOriginal.Image = global::GraphFilter.Properties.Resources.icons8_zoom_to_actual_size;
            this.buttonZoomOriginal.Location = new System.Drawing.Point(41, 61);
            this.buttonZoomOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOriginal.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonZoomOriginal.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonZoomOriginal.Name = "buttonZoomOriginal";
            this.buttonZoomOriginal.Size = new System.Drawing.Size(38, 41);
            this.buttonZoomOriginal.TabIndex = 55;
            this.buttonZoomOriginal.UseVisualStyleBackColor = false;
            this.buttonZoomOriginal.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.BackColor = System.Drawing.Color.White;
            this.buttonZoomOut.FlatAppearance.BorderSize = 0;
            this.buttonZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOut.Image = global::GraphFilter.Properties.Resources.icons8_zoom_out;
            this.buttonZoomOut.Location = new System.Drawing.Point(79, 61);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOut.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonZoomOut.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(38, 41);
            this.buttonZoomOut.TabIndex = 54;
            this.buttonZoomOut.UseVisualStyleBackColor = false;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click_1);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.BackColor = System.Drawing.Color.White;
            this.buttonZoomIn.FlatAppearance.BorderSize = 0;
            this.buttonZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomIn.Image = global::GraphFilter.Properties.Resources.icons8_zoom_in;
            this.buttonZoomIn.Location = new System.Drawing.Point(116, 61);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomIn.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonZoomIn.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(38, 41);
            this.buttonZoomIn.TabIndex = 45;
            this.buttonZoomIn.UseVisualStyleBackColor = false;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonExp2PNG
            // 
            this.buttonExp2PNG.BackColor = System.Drawing.Color.White;
            this.buttonExp2PNG.FlatAppearance.BorderSize = 0;
            this.buttonExp2PNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExp2PNG.Image = global::GraphFilter.Properties.Resources.icons8_png;
            this.buttonExp2PNG.Location = new System.Drawing.Point(154, 61);
            this.buttonExp2PNG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExp2PNG.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonExp2PNG.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonExp2PNG.Name = "buttonExp2PNG";
            this.buttonExp2PNG.Size = new System.Drawing.Size(38, 41);
            this.buttonExp2PNG.TabIndex = 45;
            this.buttonExp2PNG.UseVisualStyleBackColor = false;
            this.buttonExp2PNG.Click += new System.EventHandler(this.buttonExp2PNG_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = global::GraphFilter.Properties.Resources.print_32;
            this.buttonPrint.Location = new System.Drawing.Point(268, 61);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrint.MaximumSize = new System.Drawing.Size(38, 41);
            this.buttonPrint.MinimumSize = new System.Drawing.Size(38, 41);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(38, 41);
            this.buttonPrint.TabIndex = 45;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(750, 37);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(83, 19);
            this.lblVersion.TabIndex = 53;
            this.lblVersion.Text = "Version: 1.0.0";
            // 
            // chkUpdBtn
            // 
            this.chkUpdBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUpdBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.chkUpdBtn.Location = new System.Drawing.Point(822, 37);
            this.chkUpdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chkUpdBtn.MaximumSize = new System.Drawing.Size(150, 19);
            this.chkUpdBtn.MinimumSize = new System.Drawing.Size(150, 19);
            this.chkUpdBtn.Name = "chkUpdBtn";
            this.chkUpdBtn.Size = new System.Drawing.Size(150, 19);
            this.chkUpdBtn.TabIndex = 54;
            this.chkUpdBtn.Text = "Check For Updates";
            this.chkUpdBtn.UseSelectable = true;
            this.chkUpdBtn.Click += new System.EventHandler(this.chkUpdBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GraphFilter.Properties.Resources.IconeGraphFilter;
            this.pictureBox1.Location = new System.Drawing.Point(177, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 54);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 851);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.chkUpdBtn);
            this.Controls.Add(this.lblVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(540, 406);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Graph Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.listInvResults)).EndInit();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxEq.ResumeLayout(false);
            this.groupBoxEq.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxEq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listOfG6;
        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonZoomOriginal;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonExp2PNG;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button verifyEq1;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private MetroFramework.Controls.MetroTextBox textSource;
        private MetroFramework.Controls.MetroTextBox textOutPath;
        private System.Windows.Forms.Button buttonOpen;
        public MetroFramework.Controls.MetroTextBox paramRegularWithDegree;
        public MetroFramework.Controls.MetroTextBox textEquation1;
        public MetroFramework.Controls.MetroProgressBar progressBar;
        public MetroFramework.Controls.MetroTextBox textOpenViz;
        private MetroFramework.Controls.MetroLabel ListOfInvariants;
        private MetroFramework.Controls.MetroLabel lblVersion;
        private System.Windows.Forms.DataGridView listInvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaInvariant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaResultado;
        private MetroFramework.Controls.MetroTextBox insertG6ToView;
        private MetroFramework.Controls.MetroButton viewG6Btn;
        private MetroFramework.Controls.MetroButton openG6BtnViz;
        private MetroFramework.Controls.MetroLabel showGraphInvariantLbl;
        private JCS.ToggleSwitch showInvariantsCheck;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public JCS.ToggleSwitch enableRegular;
        public JCS.ToggleSwitch enableRegularWithK;
        public JCS.ToggleSwitch enableIsAcyclic;
        public JCS.ToggleSwitch enableIsPlanar;
        public JCS.ToggleSwitch enableIsHamiltonian;
        public JCS.ToggleSwitch enableIsConnected;
        public JCS.ToggleSwitch enableEq1;
        private MetroFramework.Controls.MetroButton chkUpdBtn;
        private System.Windows.Forms.Button buttonCounterexample;
        private System.Windows.Forms.Button buttonExportAll;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExportTikZ;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        public JCS.ToggleSwitch enableSome_Q_integer;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        public JCS.ToggleSwitch enableSome_L_integer;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        public JCS.ToggleSwitch enable_Q_integral;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        public JCS.ToggleSwitch enableSome_A_integer;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        public JCS.ToggleSwitch enableLarg_Q_integer;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        public JCS.ToggleSwitch enable_L_integral;
        public JCS.ToggleSwitch enable_A_integral;
        public JCS.ToggleSwitch enableLarg_L_integer;
        public JCS.ToggleSwitch enableLarg_A_integer;
    }
}

