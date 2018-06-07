using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using EntityFrmMSAccess.GDataSetTableAdapters;
using System.Globalization;

namespace EntityFrmMSAccess
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        STableAdapter adapter = new STableAdapter();
        GDataSet individual = new GDataSet();
        ContextMenuStrip docMenu;

        DataTable tb;
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb = new DataTable();
            adapter.Fill(individual.Sections);
                      //SectionDataSet.Tables.Add(tb);
            tb = individual.Tables[0];

            PopulateTreeView(treeView1.Nodes, 0, tb);
            SetContxtMenu();

            //DataRow[] selected = tb.Select("SectionName ='Mbogo'");
            //foreach (DataRow row in selected)
            //{
            //   int ID = (int) row["BelongsTo"];
            //}

            treeView1.ItemDrag += new ItemDragEventHandler(Item_Drag);
            treeView1.DragEnter += new DragEventHandler(Drag_Enter);
            treeView1.DragOver += new DragEventHandler(Drag_Over);
            treeView1.DragDrop += new DragEventHandler(Drag_Drop);


            this.cmbParent.DataSource = individual.Sections;
            this.cmbParent.ValueMember = "SectionID";
            this.cmbParent.DisplayMember = "SectionName";

            //this.bxPicture.Image = new Bitmap(@"C:\Users\Jesse\Documents\Visual Studio 2013\Projects\Current\EntityFrmMSAccess\Images\NoFace.png");
            //this.bxPicture.Image = new Bitmap(@"..\..\..\Images\NoFace.png");

        }

        private void Drag_Drop(object sender, DragEventArgs e)
        {
            
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = treeView1.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Confirm that the node at the drop location is not 
            // the dragged node or a descendant of the dragged node.
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                // If it is a move operation, remove the node from its current 
                // location and add it to the node at the drop location.
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                // If it is a copy operation, clone the dragged node 
                // and add it to the node at the drop location.
                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                }

                ////Save DataSet
                ////===================
                ////DataRow[] selected = tb.Select("SectionName = '" + targetNode + "'");
                DataRow[] selected = individual.Sections.Select("SectionName ='" + targetNode.Text + "'");
                foreach (DataRow row in selected)
                {
                    ID = (int)row["SectionID"];
                }

                DataRow[] selecteddragged = individual.Sections.Select("SectionName = '" + draggedNode.Text + "'");
                foreach (DataRow row in selecteddragged)
                {
                    row["BelongsTo"] = ID;
                }
                adapter.Update(individual.Sections);
     
                // Expand the node at the location 
                // to show the dropped node.
                targetNode.Expand();
            }
        }
        // Determine whether one node is a parent 
        // or ancestor of a second node.
        private bool ContainsNode(TreeNode draggedNode, TreeNode targetNode)
        {
            // Check the parent node of the second node.
            if (targetNode.Parent == null) return false;
            if (targetNode.Parent.Equals(draggedNode)) return true;

            // If the parent node is not null or equal to the first node, 
            // call the ContainsNode method recursively using the parent of 
            // the second node.
            return ContainsNode(draggedNode, targetNode.Parent);
        }

        // Select the node under the mouse pointer to indicate the 
        // expected drop location.
        private void Drag_Over(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the mouse position.
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));

            // Select the node at the mouse position.
            treeView1.SelectedNode = treeView1.GetNodeAt(targetPoint);
        }

        // Set the target drop effect to the effect 
        // specified in the ItemDrag event handler.
        private void Drag_Enter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void Item_Drag(object sender, ItemDragEventArgs e)
        {
            // Move the dragged node when the left mouse button is used.
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }

            // Copy the dragged node when the right mouse button is used.
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        protected void PopulateTreeView(TreeNodeCollection parentNode, int parentID, DataTable folders)
        {
            foreach (DataRow folder in folders.Rows)
            {
                if (Convert.ToInt32(folder["BelongsTo"]) == parentID)
                {
                    String key = folder["SectionID"].ToString();
                    //String text = folder["SectionName"].ToString();
                    String text = folder["FirstName"].ToString() + " " + folder["SectionName"].ToString();
                    String gender = folder["Gender"].ToString();
                    if (gender == "M")
                    {
                        TreeNodeCollection newParentNode = parentNode.Add(key, text,4,4).Nodes;
                                        
                        PopulateTreeView(newParentNode, Convert.ToInt32(folder["SectionID"]), folders);
                    }
                    else if (gender == "F")
                    {
                        TreeNodeCollection newParentNode = parentNode.Add(key, text, 5,5).Nodes;
                        PopulateTreeView(newParentNode, Convert.ToInt32(folder["SectionID"]), folders);
                    }
                    else
                    {
                        TreeNodeCollection newParentNode = parentNode.Add(key, text, 1,1).Nodes;
                        PopulateTreeView(newParentNode, Convert.ToInt32(folder["SectionID"]), folders);

                    }
                 
                }
            }
        }

        //To iterate through all nodes of the TreeView control
        //=====================================================
        private void PrintRecursive(TreeNode treeNode)
        {
            // Print the node.
            System.Diagnostics.Debug.WriteLine(treeNode.Text);
            MessageBox.Show(treeNode.Text);
            // Print each node recursively.
            foreach (TreeNode tn in treeNode.Nodes)
            {
                PrintRecursive(tn);
            }
        }

        // Call the procedure using the TreeView.
        private void CallRecursive(TreeView treeView)
        {
            // Print each node recursively.
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                PrintRecursive(n);
            }
        }

        private TreeNode GetNodeByText(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Text == searchtext)
                {
                    b_node_found = true;
                    node.BackColor = Color.Yellow;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByText(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }

        private void FindInTreeView(TreeNodeCollection tncoll, string strNode)
        {
            foreach (TreeNode tnode in tncoll)
            {
                if (tnode.Text.ToLower() == strNode.ToLower())
                {
                    tnode.BackColor = Color.Yellow;
                    tnode.TreeView.SelectedNode = tnode;
                }
                else
                {
                    tnode.BackColor = tnode.TreeView.BackColor;
                }
                FindInTreeView(tnode.Nodes, strNode);
            }
            ////http://www.dotnetcurry.com/ShowArticle.aspx?ID=201
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    FindInTreeView(treeView1.Nodes, "Mabiriizi");
        //}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Determine by checking the Text property.
            TreeNode node = new TreeNode();
            node = treeView1.SelectedNode;
            txtPath.Text = node.FullPath;

            var query = from o in individual.Sections
                        where o.SectionID == Convert.ToInt32(node.Name)
                        select new
                        {
                            SectionId = o.SectionID,
                            SectionName = o.SectionName,
                            FirstName = o.IsFirstNameNull() ? null : o.FirstName,   //.IsRemarkNull() ? null : d.Remark
                            Gender = o.IsGenderNull() ? null : o.Gender,
                            BelongsTo = o.BelongsTo,
                            photo = o.IsSectionDistributionGroupNameNull()? "NoFace.png":o.SectionDistributionGroupName

                        };

            foreach (var o in query)
            {
                //*******************************************************************************************************************************************************
                //   Normal:        The image is placed in the upper-left corner of the PictureBox. The image is clipped if it is larger than the PictureBox it is contained in.
                //   StretchImage:  The image within the PictureBox is stretched or shrunk to fit the size of the PictureBox.
                //   AutoSize:      The PictureBox is sized equal to the size of the image that it contains.
                //   CenterImage:   The image is displayed in the center if the PictureBox is larger than the image.If the image is larger than the PictureBox, 
                //                  the picture is placed in the center of the PictureBox and the outside edges are clipped.
                //   Zoom:          The size of the image is increased or decreased maintaining the size ratio.
                //*******************************************************************************************************************************************************

                this.txtSectionID.Text = o.SectionId.ToString();
                this.txtLastName.Text = o.SectionName;
                this.txtFirstName.Text = o.FirstName;
                this.bxPicture.Image = new Bitmap(@"..\..\..\Images\"+ o.photo.ToString() );
                this.bxPicture.SizeMode = PictureBoxSizeMode.Zoom; 
                this.lblPictName.Text = o.FirstName + " " + o.SectionName;
                if (o.Gender == "M")
                { cmbGender.SelectedIndex = cmbGender.FindStringExact("Male"); }
                else if (o.Gender == "F")
                {
                    cmbGender.SelectedIndex = cmbGender.FindStringExact("Female"); ;
                }
                this.cmbParent.SelectedValue = o.BelongsTo; //.SelectedIndex = 3
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FindInTreeView(treeView1.Nodes, txtSearch.Text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            string SectionName;
            string FirstName = "";
            int Belongs;
            string Gender = "";


            string Created = "jbusuulwa";
            SectionName = this.txtLastName.Text;
            FirstName = this.txtFirstName.Text;
            Belongs = (int)this.cmbParent.SelectedValue;
            if (cmbGender.SelectedItem.ToString() == "Male")
            {
                Gender = "M";
            }
            else if (this.cmbGender.SelectedItem.ToString() == "Female")

            {
                Gender = "F";
            }

            if (string.IsNullOrWhiteSpace(txtSectionID.Text))
            {
                 
                var newRow = individual.Tables["Sections"].NewRow();
                newRow["SectionName"] = SectionName;
                newRow["FirstName"] = FirstName;
                newRow["SectionDistributionGroupName"] = "N/A";
                newRow["BelongsTo"] = Belongs;
                newRow["SectionIdPath"] = "//";
                newRow["SectionPath"] = "//";
                newRow["Gender"] = Gender;
                newRow["Notes"] = "None";
                newRow["CreatedBy"] = Created;

                individual.Tables["Sections"].Rows.Add(newRow);

                adapter.Update(individual.Sections);
                //adapter.Insert(SectionName,FirstName,"N/A",Belongs,"//","//",Gender,"None",Created);

                treeView1.Nodes.Clear();

                adapter.Fill(individual.Sections);
                FindInTreeView(treeView1.Nodes, SectionName);
            }
            else
            {

                DataRow[] selected = individual.Sections.Select("SectionID =" + Convert.ToInt32(this.txtSectionID.Text));
                foreach (DataRow row in selected)
                {

                   row["SectionName"] =SectionName;
                   row["FirstName"]= FirstName;
                   row["BelongsTo"] = Belongs;
                   row["Gender"] = Gender;
                    row["CreatedBy"] = Created;
                }

                TreeNode node = new TreeNode();
                node = treeView1.SelectedNode;
                node.Text = SectionName;
                adapter.Update(individual.Sections);
                treeView1.EndUpdate();

            }

        }

        private void SaveNode(string Name, string gender, int Parent)
        {

            string SectionName = Name;
            string FirstName = this.txtFirstName.Text;
            int Belongs = Parent;
            string Gender = gender;
            string Created = "jbusuulwa";

            var newRow = individual.Tables["Sections"].NewRow();
            newRow["SectionName"] = SectionName;
            newRow["FirstName"] = FirstName;
            newRow["SectionDistributionGroupName"] = "N/A";
            newRow["BelongsTo"] = Belongs;
            newRow["SectionIdPath"] = "//";
            newRow["SectionPath"] = "//";

            Gender = "M";

            newRow["Gender"] = Gender;
            newRow["Notes"] = "None";
            newRow["CreatedBy"] = Created;


            individual.Tables["Sections"].Rows.Add(newRow);
            adapter.Update(individual.Sections);
            
            //adapter.Insert(SectionName,FirstName,"N/A",Belongs,"//","//",Gender,"None",Created);

            //treeView1.Nodes.Clear();
            //PopulateTreeView(treeView1.Nodes, 0, tb);
            //FindInTreeView(treeView1.Nodes, SectionName);
            //treeView1.Nodes.Find(SectionName, true);


        }

        // INCLUDING CONTEXT-MENU
        // There is a very good guide at
        // this site: http://www.authorcode.com/add-contextmenu-to-treeview-nodes-in-c/
        //
        private void SetContxtMenu()
        {
            treeView1.ContextMenuStrip = this.contextMenuStrip1;
            foreach (TreeNode RootNode in treeView1.Nodes)
            {
                RootNode.ContextMenuStrip = contextMenuStrip2;
                foreach (TreeNode ChildNode in RootNode.Nodes)
                {
                    ChildNode.ContextMenuStrip = contextMenuStrip2;
                }
            }
        }

        private void AddChildRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Id = "";
            frmEnterText frm = new frmEnterText();
            frm.ShowDialog();
            string TempNodeText = frm.Get_FormText();
            string TempGenderTxt = frm.Get_GenderText();
            frm.Dispose();
            if (!string.IsNullOrEmpty(TempNodeText.Trim()))
            {
                int i = Convert.ToInt32(treeView1.SelectedNode.Name);
                SaveNode(TempNodeText, TempGenderTxt, i);
                adapter.Fill(individual.Sections);
                DataRow[] selected = individual.Sections.Select("SectionName ='" + TempNodeText + "'");
                foreach (DataRow row in selected)
                {
                    Id = row["SectionID"].ToString();
                }

                TreeNode _Node = new TreeNode();
                _Node.Text = TempNodeText;
                _Node.Name = Id;
                _Node.ContextMenuStrip = contextMenuStrip2;

               if (TempGenderTxt == "F")  { _Node.ImageIndex = 5; _Node.SelectedImageIndex = 5;}
               if (TempGenderTxt == "M")  { _Node.ImageIndex = 4; _Node.SelectedImageIndex = 4; }

                treeView1.SelectedNode.Nodes.Add(_Node);
            }

        }

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnterText frm = new frmEnterText();
            frm.ShowDialog();
            string TempNodeText = frm.Get_FormText();
            frm.Dispose();

            TreeNode SelectedNode = treeView1.SelectedNode;
            int i = Convert.ToInt32(SelectedNode.Name);
            if (!string.IsNullOrEmpty(TempNodeText.Trim()))
            {
                DataRow[] selected = individual.Sections.Select("SectionID =" + i);
                foreach (DataRow row in selected)
                {
                    row["SectionName"] = TempNodeText;
                }
                adapter.Update(individual.Sections);
                SelectedNode.Text = TempNodeText;
            }
            treeView1.EndUpdate();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode toDeleteNode = treeView1.SelectedNode;

            if (MessageBox.Show("Are you sure you want to delete " + toDeleteNode.Text + "?",
                    "Deleting " + toDeleteNode.Text + "!",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                toDeleteNode.Remove();
                int i = Convert.ToInt32(toDeleteNode.Name);
                individual.Sections.Rows.Find(i).Delete();
                adapter.Update(individual.Sections);
                treeView1.EndUpdate();
            }

           
        }

        private void AddNewRootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnterText frm = new frmEnterText();

            frm.ShowDialog();

            string TempNodeText = frm.Get_FormText();
            frm.Dispose();
            if (!string.IsNullOrEmpty(TempNodeText.Trim()))
            {
                TreeNode _Node = new TreeNode();
                _Node.Text = TempNodeText;
                _Node.ContextMenuStrip = contextMenuStrip2;
                treeView1.Nodes.Add(_Node);
            }
        }

        private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            PopulateTreeView(treeView1.Nodes, 0, tb);
            SetContxtMenu();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.txtSectionID.Clear();
            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.cmbGender.SelectedIndex = -1;
            this.cmbParent.SelectedIndex = -1;
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            FindInTreeView(treeView1.Nodes, txtSearch.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Set title bar to selected date.
            DateTime result = dateTimePicker1.Value;
            this.textDOB.Text =result.ToString("MM/dd/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Set title bar to selected date.
            DateTime result = dateTimePicker1.Value;
            this.textDOD.Text = result.ToString("MM/dd/yyyy");
        }
    }
}
