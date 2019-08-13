namespace finalReview
{
    partial class CharacterGenerationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGenerationForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.SkillsPage = new System.Windows.Forms.TabPage();
            this.CharacterSheetPage = new System.Windows.Forms.TabPage();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.IdentityTableLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameDataLabel = new System.Windows.Forms.Label();
            this.LastNameDataLabel = new System.Windows.Forms.Label();
            this.GeneratesNameButton = new System.Windows.Forms.Button();
            this.AbilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateAbilitiesButton = new System.Windows.Forms.Button();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.EnduranceLabel = new System.Windows.Forms.Label();
            this.IntellectLabel = new System.Windows.Forms.Label();
            this.EducationLabel = new System.Windows.Forms.Label();
            this.DexeterityLabel = new System.Windows.Forms.Label();
            this.SocialstandingLable = new System.Windows.Forms.Label();
            this.StrengthDataLabel = new System.Windows.Forms.Label();
            this.DexeterityDataLabel = new System.Windows.Forms.Label();
            this.EnduranceDataLabel = new System.Windows.Forms.Label();
            this.EducationDataLabel = new System.Windows.Forms.Label();
            this.IntellectDataLabel = new System.Windows.Forms.Label();
            this.SocialstandingDataLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainTabControl.SuspendLayout();
            this.IdentityPage.SuspendLayout();
            this.AbilityPage.SuspendLayout();
            this.CharacterSheetPage.SuspendLayout();
            this.IdentityTableLayoutPannel.SuspendLayout();
            this.AbilitiesTableLayoutPanel.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.IdentityPage);
            this.MainTabControl.Controls.Add(this.AbilityPage);
            this.MainTabControl.Controls.Add(this.SkillsPage);
            this.MainTabControl.Controls.Add(this.CharacterSheetPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(784, 447);
            this.MainTabControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Controls.Add(this.IdentityTableLayoutPannel);
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(776, 410);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Controls.Add(this.AbilitiesTableLayoutPanel);
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(776, 410);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Abilities";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // SkillsPage
            // 
            this.SkillsPage.Location = new System.Drawing.Point(4, 33);
            this.SkillsPage.Name = "SkillsPage";
            this.SkillsPage.Size = new System.Drawing.Size(776, 410);
            this.SkillsPage.TabIndex = 2;
            this.SkillsPage.Text = "Skills";
            this.SkillsPage.UseVisualStyleBackColor = true;
            // 
            // CharacterSheetPage
            // 
            this.CharacterSheetPage.Controls.Add(this.MainToolStrip);
            this.CharacterSheetPage.Controls.Add(this.MainMenuStrip);
            this.CharacterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.CharacterSheetPage.Name = "CharacterSheetPage";
            this.CharacterSheetPage.Size = new System.Drawing.Size(776, 410);
            this.CharacterSheetPage.TabIndex = 3;
            this.CharacterSheetPage.Text = "Character Sheet";
            this.CharacterSheetPage.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(636, 469);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(136, 63);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 469);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(136, 63);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // IdentityTableLayoutPannel
            // 
            this.IdentityTableLayoutPannel.ColumnCount = 4;
            this.IdentityTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.Controls.Add(this.FirstNameLabel, 0, 0);
            this.IdentityTableLayoutPannel.Controls.Add(this.GeneratesNameButton, 2, 3);
            this.IdentityTableLayoutPannel.Controls.Add(this.LastNameLabel, 0, 1);
            this.IdentityTableLayoutPannel.Controls.Add(this.FirstNameDataLabel, 1, 0);
            this.IdentityTableLayoutPannel.Controls.Add(this.LastNameDataLabel, 1, 1);
            this.IdentityTableLayoutPannel.Location = new System.Drawing.Point(0, 3);
            this.IdentityTableLayoutPannel.Name = "IdentityTableLayoutPannel";
            this.IdentityTableLayoutPannel.RowCount = 4;
            this.IdentityTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IdentityTableLayoutPannel.Size = new System.Drawing.Size(768, 343);
            this.IdentityTableLayoutPannel.TabIndex = 0;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(186, 85);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(3, 85);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(186, 85);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstNameDataLabel
            // 
            this.FirstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNameDataLabel.AutoSize = true;
            this.FirstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPannel.SetColumnSpan(this.FirstNameDataLabel, 3);
            this.FirstNameDataLabel.Location = new System.Drawing.Point(195, 0);
            this.FirstNameDataLabel.Name = "FirstNameDataLabel";
            this.FirstNameDataLabel.Size = new System.Drawing.Size(570, 85);
            this.FirstNameDataLabel.TabIndex = 0;
            this.FirstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LastNameDataLabel
            // 
            this.LastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameDataLabel.AutoSize = true;
            this.LastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdentityTableLayoutPannel.SetColumnSpan(this.LastNameDataLabel, 3);
            this.LastNameDataLabel.Location = new System.Drawing.Point(195, 85);
            this.LastNameDataLabel.Name = "LastNameDataLabel";
            this.LastNameDataLabel.Size = new System.Drawing.Size(570, 85);
            this.LastNameDataLabel.TabIndex = 0;
            this.LastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneratesNameButton
            // 
            this.GeneratesNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentityTableLayoutPannel.SetColumnSpan(this.GeneratesNameButton, 2);
            this.GeneratesNameButton.Location = new System.Drawing.Point(387, 258);
            this.GeneratesNameButton.Name = "GeneratesNameButton";
            this.GeneratesNameButton.Size = new System.Drawing.Size(378, 82);
            this.GeneratesNameButton.TabIndex = 1;
            this.GeneratesNameButton.Text = "Generate Name";
            this.GeneratesNameButton.UseVisualStyleBackColor = true;
            // 
            // AbilitiesTableLayoutPanel
            // 
            this.AbilitiesTableLayoutPanel.ColumnCount = 4;
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.AbilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthDataLabel, 1, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexeterityLabel, 0, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.StrengthLabel, 0, 0);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.GenerateAbilitiesButton, 2, 7);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EnduranceLabel, 0, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntellectLabel, 0, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EducationLabel, 0, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.SocialstandingLable, 0, 5);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.DexeterityDataLabel, 1, 1);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EnduranceDataLabel, 1, 2);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.IntellectDataLabel, 1, 3);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.EducationDataLabel, 1, 4);
            this.AbilitiesTableLayoutPanel.Controls.Add(this.SocialstandingDataLabel, 1, 5);
            this.AbilitiesTableLayoutPanel.Location = new System.Drawing.Point(9, 7);
            this.AbilitiesTableLayoutPanel.Name = "AbilitiesTableLayoutPanel";
            this.AbilitiesTableLayoutPanel.RowCount = 8;
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AbilitiesTableLayoutPanel.Size = new System.Drawing.Size(759, 397);
            this.AbilitiesTableLayoutPanel.TabIndex = 0;
            // 
            // GenerateAbilitiesButton
            // 
            this.GenerateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AbilitiesTableLayoutPanel.SetColumnSpan(this.GenerateAbilitiesButton, 2);
            this.GenerateAbilitiesButton.Location = new System.Drawing.Point(419, 346);
            this.GenerateAbilitiesButton.Name = "GenerateAbilitiesButton";
            this.GenerateAbilitiesButton.Size = new System.Drawing.Size(337, 48);
            this.GenerateAbilitiesButton.TabIndex = 2;
            this.GenerateAbilitiesButton.Text = "Generate Abilities";
            this.GenerateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(3, 0);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(259, 49);
            this.StrengthLabel.TabIndex = 2;
            this.StrengthLabel.Text = "Strength";
            this.StrengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnduranceLabel
            // 
            this.EnduranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceLabel.AutoSize = true;
            this.EnduranceLabel.Location = new System.Drawing.Point(3, 98);
            this.EnduranceLabel.Name = "EnduranceLabel";
            this.EnduranceLabel.Size = new System.Drawing.Size(259, 49);
            this.EnduranceLabel.TabIndex = 3;
            this.EnduranceLabel.Text = "Endurance";
            this.EnduranceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntellectLabel
            // 
            this.IntellectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectLabel.AutoSize = true;
            this.IntellectLabel.Location = new System.Drawing.Point(3, 147);
            this.IntellectLabel.Name = "IntellectLabel";
            this.IntellectLabel.Size = new System.Drawing.Size(259, 49);
            this.IntellectLabel.TabIndex = 4;
            this.IntellectLabel.Text = "Intellect";
            this.IntellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EducationLabel
            // 
            this.EducationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationLabel.AutoSize = true;
            this.EducationLabel.Location = new System.Drawing.Point(3, 196);
            this.EducationLabel.Name = "EducationLabel";
            this.EducationLabel.Size = new System.Drawing.Size(259, 49);
            this.EducationLabel.TabIndex = 5;
            this.EducationLabel.Text = "Education";
            this.EducationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DexeterityLabel
            // 
            this.DexeterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexeterityLabel.AutoSize = true;
            this.DexeterityLabel.Location = new System.Drawing.Point(3, 49);
            this.DexeterityLabel.Name = "DexeterityLabel";
            this.DexeterityLabel.Size = new System.Drawing.Size(259, 49);
            this.DexeterityLabel.TabIndex = 6;
            this.DexeterityLabel.Text = "Dexeterity";
            this.DexeterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SocialstandingLable
            // 
            this.SocialstandingLable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialstandingLable.AutoSize = true;
            this.SocialstandingLable.Location = new System.Drawing.Point(3, 245);
            this.SocialstandingLable.Name = "SocialstandingLable";
            this.SocialstandingLable.Size = new System.Drawing.Size(259, 49);
            this.SocialstandingLable.TabIndex = 7;
            this.SocialstandingLable.Text = "Social Standing";
            this.SocialstandingLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrengthDataLabel
            // 
            this.StrengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StrengthDataLabel.AutoSize = true;
            this.StrengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrengthDataLabel.Location = new System.Drawing.Point(268, 0);
            this.StrengthDataLabel.Name = "StrengthDataLabel";
            this.StrengthDataLabel.Size = new System.Drawing.Size(145, 49);
            this.StrengthDataLabel.TabIndex = 2;
            this.StrengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DexeterityDataLabel
            // 
            this.DexeterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DexeterityDataLabel.AutoSize = true;
            this.DexeterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DexeterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DexeterityDataLabel.Location = new System.Drawing.Point(268, 49);
            this.DexeterityDataLabel.Name = "DexeterityDataLabel";
            this.DexeterityDataLabel.Size = new System.Drawing.Size(145, 49);
            this.DexeterityDataLabel.TabIndex = 8;
            this.DexeterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EnduranceDataLabel
            // 
            this.EnduranceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnduranceDataLabel.AutoSize = true;
            this.EnduranceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnduranceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EnduranceDataLabel.Location = new System.Drawing.Point(268, 98);
            this.EnduranceDataLabel.Name = "EnduranceDataLabel";
            this.EnduranceDataLabel.Size = new System.Drawing.Size(145, 49);
            this.EnduranceDataLabel.TabIndex = 9;
            this.EnduranceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EducationDataLabel
            // 
            this.EducationDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EducationDataLabel.AutoSize = true;
            this.EducationDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EducationDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EducationDataLabel.Location = new System.Drawing.Point(268, 196);
            this.EducationDataLabel.Name = "EducationDataLabel";
            this.EducationDataLabel.Size = new System.Drawing.Size(145, 49);
            this.EducationDataLabel.TabIndex = 10;
            this.EducationDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IntellectDataLabel
            // 
            this.IntellectDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntellectDataLabel.AutoSize = true;
            this.IntellectDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IntellectDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntellectDataLabel.Location = new System.Drawing.Point(268, 147);
            this.IntellectDataLabel.Name = "IntellectDataLabel";
            this.IntellectDataLabel.Size = new System.Drawing.Size(145, 49);
            this.IntellectDataLabel.TabIndex = 11;
            this.IntellectDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SocialstandingDataLabel
            // 
            this.SocialstandingDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SocialstandingDataLabel.AutoSize = true;
            this.SocialstandingDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SocialstandingDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SocialstandingDataLabel.Location = new System.Drawing.Point(268, 245);
            this.SocialstandingDataLabel.Name = "SocialstandingDataLabel";
            this.SocialstandingDataLabel.Size = new System.Drawing.Size(145, 49);
            this.SocialstandingDataLabel.TabIndex = 12;
            this.SocialstandingDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(776, 24);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(776, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // CharacterGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTabControl);
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "CharacterGenerationForm";
            this.Text = "Character Generator";
            this.MainTabControl.ResumeLayout(false);
            this.IdentityPage.ResumeLayout(false);
            this.AbilityPage.ResumeLayout(false);
            this.CharacterSheetPage.ResumeLayout(false);
            this.CharacterSheetPage.PerformLayout();
            this.IdentityTableLayoutPannel.ResumeLayout(false);
            this.IdentityTableLayoutPannel.PerformLayout();
            this.AbilitiesTableLayoutPanel.ResumeLayout(false);
            this.AbilitiesTableLayoutPanel.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage SkillsPage;
        private System.Windows.Forms.TabPage CharacterSheetPage;
        private System.Windows.Forms.TableLayoutPanel IdentityTableLayoutPannel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button GeneratesNameButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameDataLabel;
        private System.Windows.Forms.Label LastNameDataLabel;
        private System.Windows.Forms.TableLayoutPanel AbilitiesTableLayoutPanel;
        private System.Windows.Forms.Label DexeterityLabel;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateAbilitiesButton;
        private System.Windows.Forms.Label EnduranceLabel;
        private System.Windows.Forms.Label IntellectLabel;
        private System.Windows.Forms.Label EducationLabel;
        private System.Windows.Forms.Label SocialstandingLable;
        private System.Windows.Forms.Label StrengthDataLabel;
        private System.Windows.Forms.Label DexeterityDataLabel;
        private System.Windows.Forms.Label EnduranceDataLabel;
        private System.Windows.Forms.Label IntellectDataLabel;
        private System.Windows.Forms.Label EducationDataLabel;
        private System.Windows.Forms.Label SocialstandingDataLabel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
