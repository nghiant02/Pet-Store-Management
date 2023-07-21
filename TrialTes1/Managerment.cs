using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATrialTes1
{
    public partial class Managerment : Form
    {
        PetShopMember _petShopMember;
        PetServcie _petServcie;
        PetGroupServcie _petGroupServcie;
        public Managerment(PetShopMember petShopMember)
        {
            _petServcie = new PetServcie();
            _petGroupServcie = new PetGroupServcie();
            _petShopMember = petShopMember;
            InitializeComponent();
            //Load value for combobox
            List<PetGroup> groupList = _petGroupServcie.GetAll();
            cbGroup.DataSource = groupList;
            cbGroup.ValueMember = "PetGroupId";
            cbGroup.DisplayMember = "PetGroupName";
            //Read only for combobox
            cbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            //Load list first
            if(petShopMember != null )
            {
                loadList();
            }else
            {
                MessageBox.Show("You dont have permistion to access this funtion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        internal void loadList()
        {
            List<Pet> petList = _petServcie.GetAll();
            List<PetGroup> groupList = _petGroupServcie.GetAll();
            //Join pet and group to get group name
            var joinList = petList.Join(
                groupList,
                pet => pet.PetGroupId,
                group => group.PetGroupId,
                (pet, group) => new
                {
                    pet.PetId,
                    pet.PetName,
                    pet.ImportDate,
                    pet.PetDescription,
                    pet.Quantity,
                    pet.PetPrice,
                    pet.PetGroupId,
                    group.PetGroupName,
                    //group.GroupDescription,
                    //group.OriginalSource,
                }
                ).ToList();

            dgvList.DataSource = joinList;
        }
        internal void clearTextBox()
        {
            txtDec.Text = string.Empty;
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            nudPrice.Text = string.Empty;
            nudQuantity.Text = string.Empty;
        }
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvList.Rows[e.RowIndex];
                txtID.Text = selectedRow.Cells[0].Value.ToString();
                txtName.Text = selectedRow.Cells[1].Value.ToString();
                dtpImportDate.Text = selectedRow.Cells[2].Value.ToString();
                txtDec.Text = selectedRow.Cells[3].Value.ToString();
                nudQuantity.Value = int.Parse(selectedRow.Cells[4].Value.ToString());
                nudPrice.Value = int.Parse(selectedRow.Cells[5].Value.ToString());
                cbGroup.Text = selectedRow.Cells[7].Value.ToString();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(_petShopMember != null)
            {
                List<Pet> searchResultList = _petServcie.SearchByKeyword(pet => pet.Quantity.ToString().Contains(txtSearch.Text) || pet.PetPrice.ToString().Contains(txtSearch.Text));
                List<PetGroup> groupList = _petGroupServcie.GetAll();

                var jointSearchList = searchResultList.Join(
                    groupList,
                    pet => pet.PetGroupId,
                    group => group.PetGroupId,
                    (pet, group) => new
                    {
                        pet.PetId,
                        pet.PetName,
                        pet.ImportDate,
                        pet.PetDescription,
                        pet.Quantity,
                        pet.PetPrice,
                        pet.PetGroupId,
                        group.PetGroupName,
                    }
                    ).ToList();

                dgvList.DataSource = jointSearchList;
            }
            else
            {
                MessageBox.Show("You dont have permistion to access this funtion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(_petShopMember != null)
            {
                Pet lastPet = _petServcie.GetAll().OrderByDescending(p => p.PetId).FirstOrDefault();
                Pet newPet = new Pet()
                {
                    PetId = lastPet.PetId + 1,
                    PetName = txtName.Text,
                    PetDescription = txtDec.Text,
                    ImportDate = dtpImportDate.Value,
                    Quantity = Convert.ToInt32(nudQuantity.Value),
                    PetPrice = Convert.ToInt32(nudPrice.Value),
                    PetGroupId = cbGroup.SelectedValue.ToString(),
                };
                bool added = _petServcie.Add(newPet);
                if (added)
                {
                    MessageBox.Show("Add pet sucessfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadList();
                    clearTextBox();
                }
            }
            else
            {
                MessageBox.Show("You dont have permistion to access this funtion","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_petShopMember != null)
            {
                try
                {
                    Pet pet = _petServcie.GetAll().Where(p => p.PetId == int.Parse(txtID.Text)).FirstOrDefault();

                    if (pet != null)
                    {
                        pet.PetName = txtName.Text;
                        pet.ImportDate = dtpImportDate.Value;
                        pet.PetDescription = txtDec.Text;
                        pet.PetPrice = Convert.ToInt32(nudPrice.Value);
                        pet.Quantity = Convert.ToInt32(nudQuantity.Value);
                        pet.PetGroupId = cbGroup.SelectedValue.ToString();

                        bool updated = _petServcie.Update(pet);
                        if (updated)
                        {
                            MessageBox.Show("Update sucessfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadList();
                            clearTextBox();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please click on the record to selete pet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You dont have permistion to access this funtion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_petShopMember != null)
            {
                try
                {
                    Pet pet = _petServcie.GetAll().Where(p => p.PetId == int.Parse(txtID.Text)).FirstOrDefault();
                    if (pet != null)
                    {
                        DialogResult mess = MessageBox.Show("Do you want to delete this pet!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mess == DialogResult.Yes)
                        {
                            bool deleted = _petServcie.Remove(pet);
                            loadList();
                            clearTextBox();
                        }
                        else if (mess == DialogResult.No)
                        {
                            MessageBox.Show("Nothing change!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Please click on the record to selete pet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You dont have permistion to access this funtion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
