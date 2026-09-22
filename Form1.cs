using GymMembershipManagementSystem.Models;
using GymMembershipManagementSystem.Services;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GYMMEMBERSHIPMANAGEMENTSYSTEM
{
    public partial class Form1 : Form
    {
        private readonly GymManager gymManager = new GymManager();

        public Form1()
        {
            InitializeComponent();

            // Add membership types
            comboBox1.Items.Add("Basic");
            comboBox1.Items.Add("Standard");
            comboBox1.Items.Add("Premium");

            comboBox1.SelectedIndex = 0;

            // Configure DataGridView
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check Member ID
                if (!int.TryParse(textBox1.Text, out int memberId))
                {
                    MessageBox.Show(
                        "Please enter a valid numeric Member ID.",
                        "Invalid Member ID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Check Full Name
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show(
                        "Please enter the member's full name.",
                        "Missing Name",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Check Phone Number
                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show(
                        "Please enter a phone number.",
                        "Missing Phone Number",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Check Email
                if (string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show(
                        "Please enter an email address.",
                        "Missing Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Check Membership Type
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Please select a membership type.",
                        "Missing Membership Type",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Create Member object
                Member member;

                string membershipType = comboBox1.SelectedItem.ToString();

                if (membershipType == "Premium")
                {
                    member = new PremiumMember(
                        memberId,
                        textBox2.Text.Trim(),
                        textBox3.Text.Trim(),
                        textBox4.Text.Trim(),
                        membershipType,
                        true
                    );
                }
                else
                {
                    member = new Member(
                        memberId,
                        textBox2.Text.Trim(),
                        textBox3.Text.Trim(),
                        textBox4.Text.Trim(),
                        membershipType
                    );
                }

                // Add member
                gymManager.AddMember(member);

                // Display member
                RefreshMemberGrid();

                MessageBox.Show(
                    "Member added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a member to remove.",
                        "No Member Selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int memberId = Convert.ToInt32(
                    dataGridView1.SelectedRows[0]
                    .Cells["MemberId"].Value);

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to remove this member?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool removed =
                        gymManager.RemoveMember(memberId);

                    if (removed)
                    {
                        RefreshMemberGrid();

                        MessageBox.Show(
                            "Member removed successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void RefreshMemberGrid()
        {
            dataGridView1.Rows.Clear();

            foreach (Member member in gymManager.Members)
            {
                dataGridView1.Rows.Add(
    member.MemberId,
    member.FullName,
    member.PhoneNumber,
    member.Email,
    member.MembershipType,
    $"${member.Membership.MonthlyFee:F2}"
);
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comboBox1.SelectedIndex = 0;

            textBox1.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a member first.",
                    "No Member Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int memberId = Convert.ToInt32(
                dataGridView1.SelectedRows[0]
                .Cells["MemberId"].Value);

            Member member = gymManager.FindMemberById(memberId);

            if (member == null)
            {
                MessageBox.Show(
                    "Member could not be found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string details = member.GetDetails();

            if (member is PremiumMember premiumMember)
            {
                details += Environment.NewLine +
                           $"Personal Trainer: {(premiumMember.PersonalTrainerIncluded ? "Included" : "Not Included")}";
            }

            MessageBox.Show(
                details,
                "Member Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Please select a member to edit.",
                        "No Member Selected",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int memberId = Convert.ToInt32(
                    dataGridView1.SelectedRows[0]
                    .Cells["MemberId"].Value);

                Member member = gymManager.FindMemberById(memberId);

                if (member == null)
                {
                    MessageBox.Show(
                        "Member could not be found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show(
                        "Please complete all member details.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                member.FullName = textBox2.Text.Trim();
                member.PhoneNumber = textBox3.Text.Trim();
                member.Email = textBox4.Text.Trim();

                string membershipType =
                    comboBox1.SelectedItem.ToString();

                member.MembershipType = membershipType;

                decimal fee = membershipType switch
                {
                    "Basic" => 30m,
                    "Standard" => 45m,
                    "Premium" => 60m,
                    _ => 0m
                };

                member.Membership = new Membership(
                    membershipType,
                    fee,
                    member.Membership.StartDate);

                RefreshMemberGrid();

                MessageBox.Show(
                    "Member updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}