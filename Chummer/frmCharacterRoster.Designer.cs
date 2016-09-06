﻿namespace Chummer
{
	partial class frmCharacterRoster
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
			this.treCharacterList = new System.Windows.Forms.TreeView();
			this.picMugshot = new System.Windows.Forms.PictureBox();
			this.tabCharacterText = new System.Windows.Forms.TabControl();
			this.panCharacterBio = new System.Windows.Forms.TabPage();
			this.panCharacterConcept = new System.Windows.Forms.TabPage();
			this.panCharacterBackground = new System.Windows.Forms.TabPage();
			this.panCharacterNotes = new System.Windows.Forms.TabPage();
			this.txtCharacterBackground = new System.Windows.Forms.TextBox();
			this.txtCharacterBio = new System.Windows.Forms.TextBox();
			this.txtCharacterConcept = new System.Windows.Forms.TextBox();
			this.txtCharacterNotes = new System.Windows.Forms.TextBox();
			this.lblCharacterName = new System.Windows.Forms.Label();
			this.lblCharacterNameLabel = new System.Windows.Forms.Label();
			this.lblMetatype = new System.Windows.Forms.Label();
			this.lblMetatypeLabel = new System.Windows.Forms.Label();
			this.lblCareerKarma = new System.Windows.Forms.Label();
			this.lblCareerKarmaLabel = new System.Windows.Forms.Label();
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.lblPlayerNameLabel = new System.Windows.Forms.Label();
			this.lblCharacterAlias = new System.Windows.Forms.Label();
			this.lblCharacterAliasLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picMugshot)).BeginInit();
			this.tabCharacterText.SuspendLayout();
			this.panCharacterBio.SuspendLayout();
			this.panCharacterConcept.SuspendLayout();
			this.panCharacterBackground.SuspendLayout();
			this.panCharacterNotes.SuspendLayout();
			this.SuspendLayout();
			// 
			// treCharacterList
			// 
			this.treCharacterList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.treCharacterList.Location = new System.Drawing.Point(8, 8);
			this.treCharacterList.Name = "treCharacterList";
			this.treCharacterList.Size = new System.Drawing.Size(192, 536);
			this.treCharacterList.TabIndex = 0;
			this.treCharacterList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treCharacterList_AfterSelect);
			// 
			// picMugshot
			// 
			this.picMugshot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picMugshot.Location = new System.Drawing.Point(568, 8);
			this.picMugshot.Name = "picMugshot";
			this.picMugshot.Size = new System.Drawing.Size(208, 328);
			this.picMugshot.TabIndex = 21;
			this.picMugshot.TabStop = false;
			// 
			// tabCharacterText
			// 
			this.tabCharacterText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCharacterText.Controls.Add(this.panCharacterBio);
			this.tabCharacterText.Controls.Add(this.panCharacterConcept);
			this.tabCharacterText.Controls.Add(this.panCharacterBackground);
			this.tabCharacterText.Controls.Add(this.panCharacterNotes);
			this.tabCharacterText.Location = new System.Drawing.Point(208, 336);
			this.tabCharacterText.Name = "tabCharacterText";
			this.tabCharacterText.SelectedIndex = 0;
			this.tabCharacterText.Size = new System.Drawing.Size(568, 208);
			this.tabCharacterText.TabIndex = 22;
			// 
			// panCharacterBio
			// 
			this.panCharacterBio.Controls.Add(this.txtCharacterBio);
			this.panCharacterBio.Location = new System.Drawing.Point(4, 22);
			this.panCharacterBio.Name = "panCharacterBio";
			this.panCharacterBio.Padding = new System.Windows.Forms.Padding(3);
			this.panCharacterBio.Size = new System.Drawing.Size(560, 182);
			this.panCharacterBio.TabIndex = 0;
			this.panCharacterBio.Text = "Bio";
			this.panCharacterBio.UseVisualStyleBackColor = true;
			// 
			// panCharacterConcept
			// 
			this.panCharacterConcept.Controls.Add(this.txtCharacterConcept);
			this.panCharacterConcept.Location = new System.Drawing.Point(4, 22);
			this.panCharacterConcept.Name = "panCharacterConcept";
			this.panCharacterConcept.Padding = new System.Windows.Forms.Padding(3);
			this.panCharacterConcept.Size = new System.Drawing.Size(560, 182);
			this.panCharacterConcept.TabIndex = 1;
			this.panCharacterConcept.Text = "Concept";
			this.panCharacterConcept.UseVisualStyleBackColor = true;
			// 
			// panCharacterBackground
			// 
			this.panCharacterBackground.Controls.Add(this.txtCharacterBackground);
			this.panCharacterBackground.Location = new System.Drawing.Point(4, 22);
			this.panCharacterBackground.Name = "panCharacterBackground";
			this.panCharacterBackground.Padding = new System.Windows.Forms.Padding(3);
			this.panCharacterBackground.Size = new System.Drawing.Size(560, 182);
			this.panCharacterBackground.TabIndex = 2;
			this.panCharacterBackground.Text = "Background";
			this.panCharacterBackground.UseVisualStyleBackColor = true;
			// 
			// panCharacterNotes
			// 
			this.panCharacterNotes.Controls.Add(this.txtCharacterNotes);
			this.panCharacterNotes.Location = new System.Drawing.Point(4, 22);
			this.panCharacterNotes.Name = "panCharacterNotes";
			this.panCharacterNotes.Padding = new System.Windows.Forms.Padding(3);
			this.panCharacterNotes.Size = new System.Drawing.Size(560, 182);
			this.panCharacterNotes.TabIndex = 3;
			this.panCharacterNotes.Text = "Notes";
			this.panCharacterNotes.UseVisualStyleBackColor = true;
			// 
			// txtCharacterBackground
			// 
			this.txtCharacterBackground.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCharacterBackground.Location = new System.Drawing.Point(3, 3);
			this.txtCharacterBackground.Multiline = true;
			this.txtCharacterBackground.Name = "txtCharacterBackground";
			this.txtCharacterBackground.Size = new System.Drawing.Size(554, 176);
			this.txtCharacterBackground.TabIndex = 0;
			// 
			// txtCharacterBio
			// 
			this.txtCharacterBio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCharacterBio.Location = new System.Drawing.Point(3, 3);
			this.txtCharacterBio.Multiline = true;
			this.txtCharacterBio.Name = "txtCharacterBio";
			this.txtCharacterBio.Size = new System.Drawing.Size(554, 176);
			this.txtCharacterBio.TabIndex = 1;
			// 
			// txtCharacterConcept
			// 
			this.txtCharacterConcept.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCharacterConcept.Location = new System.Drawing.Point(3, 3);
			this.txtCharacterConcept.Multiline = true;
			this.txtCharacterConcept.Name = "txtCharacterConcept";
			this.txtCharacterConcept.Size = new System.Drawing.Size(554, 176);
			this.txtCharacterConcept.TabIndex = 2;
			// 
			// txtCharacterNotes
			// 
			this.txtCharacterNotes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCharacterNotes.Location = new System.Drawing.Point(3, 3);
			this.txtCharacterNotes.Multiline = true;
			this.txtCharacterNotes.Name = "txtCharacterNotes";
			this.txtCharacterNotes.Size = new System.Drawing.Size(554, 176);
			this.txtCharacterNotes.TabIndex = 2;
			// 
			// lblCharacterName
			// 
			this.lblCharacterName.AutoSize = true;
			this.lblCharacterName.Location = new System.Drawing.Point(304, 8);
			this.lblCharacterName.Name = "lblCharacterName";
			this.lblCharacterName.Size = new System.Drawing.Size(33, 13);
			this.lblCharacterName.TabIndex = 24;
			this.lblCharacterName.Text = "None";
			// 
			// lblCharacterNameLabel
			// 
			this.lblCharacterNameLabel.AutoSize = true;
			this.lblCharacterNameLabel.Location = new System.Drawing.Point(208, 8);
			this.lblCharacterNameLabel.Name = "lblCharacterNameLabel";
			this.lblCharacterNameLabel.Size = new System.Drawing.Size(87, 13);
			this.lblCharacterNameLabel.TabIndex = 23;
			this.lblCharacterNameLabel.Tag = "Label_CharacterName";
			this.lblCharacterNameLabel.Text = "Character Name:";
			// 
			// lblMetatype
			// 
			this.lblMetatype.AutoSize = true;
			this.lblMetatype.Location = new System.Drawing.Point(304, 82);
			this.lblMetatype.Name = "lblMetatype";
			this.lblMetatype.Size = new System.Drawing.Size(33, 13);
			this.lblMetatype.TabIndex = 26;
			this.lblMetatype.Text = "None";
			// 
			// lblMetatypeLabel
			// 
			this.lblMetatypeLabel.AutoSize = true;
			this.lblMetatypeLabel.Location = new System.Drawing.Point(208, 82);
			this.lblMetatypeLabel.Name = "lblMetatypeLabel";
			this.lblMetatypeLabel.Size = new System.Drawing.Size(54, 13);
			this.lblMetatypeLabel.TabIndex = 25;
			this.lblMetatypeLabel.Tag = "Label_Metatype";
			this.lblMetatypeLabel.Text = "Metatype:";
			// 
			// lblCareerKarma
			// 
			this.lblCareerKarma.AutoSize = true;
			this.lblCareerKarma.Location = new System.Drawing.Point(304, 108);
			this.lblCareerKarma.Name = "lblCareerKarma";
			this.lblCareerKarma.Size = new System.Drawing.Size(33, 13);
			this.lblCareerKarma.TabIndex = 28;
			this.lblCareerKarma.Text = "None";
			// 
			// lblCareerKarmaLabel
			// 
			this.lblCareerKarmaLabel.AutoSize = true;
			this.lblCareerKarmaLabel.Location = new System.Drawing.Point(208, 108);
			this.lblCareerKarmaLabel.Name = "lblCareerKarmaLabel";
			this.lblCareerKarmaLabel.Size = new System.Drawing.Size(74, 13);
			this.lblCareerKarmaLabel.TabIndex = 27;
			this.lblCareerKarmaLabel.Tag = "String_CareerKarma";
			this.lblCareerKarmaLabel.Text = "Career Karma:";
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Location = new System.Drawing.Point(304, 56);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(33, 13);
			this.lblPlayerName.TabIndex = 32;
			this.lblPlayerName.Text = "None";
			// 
			// lblPlayerNameLabel
			// 
			this.lblPlayerNameLabel.AutoSize = true;
			this.lblPlayerNameLabel.Location = new System.Drawing.Point(208, 56);
			this.lblPlayerNameLabel.Name = "lblPlayerNameLabel";
			this.lblPlayerNameLabel.Size = new System.Drawing.Size(70, 13);
			this.lblPlayerNameLabel.TabIndex = 31;
			this.lblPlayerNameLabel.Tag = "Label_PlayerName";
			this.lblPlayerNameLabel.Text = "Player Name:";
			// 
			// lblCharacterAlias
			// 
			this.lblCharacterAlias.AutoSize = true;
			this.lblCharacterAlias.Location = new System.Drawing.Point(304, 32);
			this.lblCharacterAlias.Name = "lblCharacterAlias";
			this.lblCharacterAlias.Size = new System.Drawing.Size(33, 13);
			this.lblCharacterAlias.TabIndex = 34;
			this.lblCharacterAlias.Text = "None";
			// 
			// lblCharacterAliasLabel
			// 
			this.lblCharacterAliasLabel.AutoSize = true;
			this.lblCharacterAliasLabel.Location = new System.Drawing.Point(208, 32);
			this.lblCharacterAliasLabel.Name = "lblCharacterAliasLabel";
			this.lblCharacterAliasLabel.Size = new System.Drawing.Size(32, 13);
			this.lblCharacterAliasLabel.TabIndex = 33;
			this.lblCharacterAliasLabel.Tag = "Label_Alias";
			this.lblCharacterAliasLabel.Text = "Alias:";
			// 
			// frmCharacterRoster
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(786, 552);
			this.Controls.Add(this.lblCharacterAlias);
			this.Controls.Add(this.lblCharacterAliasLabel);
			this.Controls.Add(this.lblPlayerName);
			this.Controls.Add(this.lblPlayerNameLabel);
			this.Controls.Add(this.lblCareerKarma);
			this.Controls.Add(this.lblCareerKarmaLabel);
			this.Controls.Add(this.lblMetatype);
			this.Controls.Add(this.lblMetatypeLabel);
			this.Controls.Add(this.lblCharacterName);
			this.Controls.Add(this.lblCharacterNameLabel);
			this.Controls.Add(this.tabCharacterText);
			this.Controls.Add(this.picMugshot);
			this.Controls.Add(this.treCharacterList);
			this.Name = "frmCharacterRoster";
			this.Text = "Character Roster";
			((System.ComponentModel.ISupportInitialize)(this.picMugshot)).EndInit();
			this.tabCharacterText.ResumeLayout(false);
			this.panCharacterBio.ResumeLayout(false);
			this.panCharacterBio.PerformLayout();
			this.panCharacterConcept.ResumeLayout(false);
			this.panCharacterConcept.PerformLayout();
			this.panCharacterBackground.ResumeLayout(false);
			this.panCharacterBackground.PerformLayout();
			this.panCharacterNotes.ResumeLayout(false);
			this.panCharacterNotes.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treCharacterList;
		private System.Windows.Forms.PictureBox picMugshot;
		private System.Windows.Forms.TabControl tabCharacterText;
		private System.Windows.Forms.TabPage panCharacterBio;
		private System.Windows.Forms.TabPage panCharacterConcept;
		private System.Windows.Forms.TabPage panCharacterBackground;
		private System.Windows.Forms.TabPage panCharacterNotes;
		private System.Windows.Forms.TextBox txtCharacterBio;
		private System.Windows.Forms.TextBox txtCharacterBackground;
		private System.Windows.Forms.TextBox txtCharacterConcept;
		private System.Windows.Forms.TextBox txtCharacterNotes;
		private System.Windows.Forms.Label lblCharacterName;
		private System.Windows.Forms.Label lblCharacterNameLabel;
		private System.Windows.Forms.Label lblMetatype;
		private System.Windows.Forms.Label lblMetatypeLabel;
		private System.Windows.Forms.Label lblCareerKarma;
		private System.Windows.Forms.Label lblCareerKarmaLabel;
		private System.Windows.Forms.Label lblPlayerName;
		private System.Windows.Forms.Label lblPlayerNameLabel;
		private System.Windows.Forms.Label lblCharacterAlias;
		private System.Windows.Forms.Label lblCharacterAliasLabel;
	}
}