using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                txtAPAMemberNumber.Focus();
            }
        }

        protected Boolean AddRegistration()
        {
            try
            {
                //setup and create the connection to the database
                ADODB.Connection objConnect = new ADODB.Connection();
                ADODB.Recordset objRs = new ADODB.Recordset();
                
                String strConnection = "Data Source=csis-sql.elmhurst.edu;Initial Catalog=MIT543-Final-Lovett;User ID=****;Password=****;Provider=msoledbsql";
                String SQL = "SELECT * FROM [Registrations];";

                //open the connection
                objConnect.Open(strConnection);
                objRs.Open(SQL, objConnect, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic);

                // add registration record
                objRs.AddNew();

                // add a new GUID for the RegistrationID field of the database
                objRs.Fields["RegistrationID"].Value = Guid.NewGuid().ToString();

                // add the captured text into the APAMemberNumber field of the database this is a required field
                objRs.Fields["APAMemberNumber"].Value = txtAPAMemberNumber.Text;

                // add the captured text into the Prefix field of the database this is a required field
                objRs.Fields["Prefix"].Value = txtNamePrefix.Text;

                // add the captured text into the FirstName field of the database this is a required field
                objRs.Fields["FirstName"].Value = txtFirstName.Text;

                // check that the text is not empty, if it is not add it to the MiddleInitial field of the database
                // if it is, set it to an empty string so the value is not null in the database this is an optional field
                if(txtMiddleInitial.Text != String.Empty)
                {
                    objRs.Fields["MiddleInitial"].Value = txtMiddleInitial.Text;
                }
                else
                {
                    objRs.Fields["MiddleInitial"].Value = String.Empty;
                }

                // add the captured text into the LastName field of the database this is a required field
                objRs.Fields["LastName"].Value = txtLastName.Text;

                // add the captured text into the Address1 field of the database this is a required field
                objRs.Fields["Address1"].Value = txtAddress1.Text;

                // check that the text is not empty, if it is not add it to the Address2 field of the database
                // if it is, set it to an empty string so the value is not null in the database this is an optional field
                if(txtAddress2.Text != String.Empty)
                {
                    objRs.Fields["Address2"].Value = txtAddress2.Text;
                }
                else
                {
                    objRs.Fields["Address2"].Value = String.Empty;
                }

                // add the captured text into the City field of the database this is a required field
                objRs.Fields["City"].Value = txtCity.Text;

                // add the captured text into the StateProvince field of the database this is a required field
                objRs.Fields["StateProvince"].Value = txtStateProvince.Text;

                // add the captured text into the ZipPostalCode field of the database this is a required field
                objRs.Fields["ZipPostalCode"].Value = txtZipPostalCode.Text;

                // add the captured text into the Country field of the database this is a required field
                objRs.Fields["Country"].Value = txtCountry.Text;

                // add the captured text into the PhoneNumber1 field of the database this is a required field
                objRs.Fields["PhoneNumber1"].Value = txtPhoneNumber1.Text;

                // check that the text is not empty, if it is not add it to the PhoneNumber2 field of the database
                // if it is, set it to an empty string so the value is not null in the database this is an optional field
                if(txtPhoneNumber2.Text != String.Empty)
                {
                    objRs.Fields["PhoneNumber2"].Value = txtPhoneNumber2.Text;
                }
                else
                {
                    objRs.Fields["PhoneNumber2"].Value = String.Empty;
                }

                // add the captured text into the EmailAddress field of the database this is a required field
                objRs.Fields["EmailAddress"].Value = txtEmailAddress.Text;

                // check that either the yes or no radio buttons are checked.  If it is, the Disability field becomes 1
                // if it is not, then it becomes 0.
                if(DisabilityYes.Checked == true)
                {
                    objRs.Fields["Disability"].Value = 1;
                }
                else if(DisabilityNo.Checked == false)
                {
                    objRs.Fields["Disability"].Value = 0;
                }

                // check that the text is not empty, if it is not add it to the DisabilityDescription field of the database
                // if it is, set it to an empty string so the value is not null in the database this is an optional field
                if(txtDisability.Text != String.Empty)
                {
                    objRs.Fields["DisabilityDescription"].Value = txtDisability.Text;
                }
                else
                {
                    objRs.Fields["DisabilityDescription"].Value = String.Empty;
                }

                //Guest1
                // add the captured text into the FirstNameGuest1 field of the database this is a required field
                if (txtFirstNameGuest1.Text != String.Empty)
                {
                    objRs.Fields["FirstNameGuest1"].Value = txtFirstNameGuest1.Text;
                }
                else
                {
                    objRs.Fields["FirstNameGuest1"].Value = String.Empty;
                }

                // add the captured text into the MiddleInitialGuest1 field of the database this is a required field
                if (txtMiddleInitialGuest1.Text != String.Empty)
                {
                    objRs.Fields["MiddleInitialGuest1"].Value = txtMiddleInitialGuest1.Text;
                }
                else
                {
                    objRs.Fields["MiddleInitialGuest1"].Value = String.Empty;
                }

                // add the captured text into the LastNameGuest1 field of the database this is a required field
                if (txtLastNameGuest1.Text != String.Empty)
                {
                    objRs.Fields["LastNameGuest1"].Value = txtLastNameGuest1.Text;
                }
                else
                {
                    objRs.Fields["LastNameGuest1"].Value = String.Empty;
                }

                //Guest2
                // add the captured text into the FirstNameGuest2 field of the database this is a required field
                if (txtFirstNameGuest1.Text != String.Empty)
                {
                    objRs.Fields["FirstNameGuest2"].Value = txtFirstNameGuest2.Text;
                }
                else
                {
                    objRs.Fields["FirstNameGuest2"].Value = String.Empty;
                }

                // add the captured text into the MiddleInitialGuest2 field of the database this is a required field
                if (txtMiddleInitialGuest2.Text != String.Empty)
                {
                    objRs.Fields["MiddleInitialGuest2"].Value = txtMiddleInitialGuest2.Text;
                }
                else
                {
                    objRs.Fields["MiddleInitialGuest2"].Value = String.Empty;
                }

                // add the captured text into the LastNameGuest2 field of the database this is a required field
                if (txtLastNameGuest2.Text != String.Empty)
                {
                    objRs.Fields["LastNameGuest2"].Value = txtLastNameGuest2.Text;
                }
                else
                {
                    objRs.Fields["LastNameGuest2"].Value = String.Empty;
                }

                //Guest3
                // add the captured text into the FirstNameGuest3 field of the database this is a required field
                if (txtFirstNameGuest3.Text != String.Empty)
                {
                    objRs.Fields["FirstNameGuest3"].Value = txtFirstNameGuest3.Text;
                }
                else
                {
                    objRs.Fields["FirstNameGuest3"].Value = String.Empty;
                }

                // add the captured text into the MiddleInitialGuest3 field of the database this is a required field
                if (txtMiddleInitialGuest3.Text != String.Empty)
                {
                    objRs.Fields["MiddleInitialGuest3"].Value = txtMiddleInitialGuest3.Text;
                }
                else
                {
                    objRs.Fields["MiddleInitialGuest3"].Value = String.Empty;
                }

                // add the captured text into the LastNameGuest3 field of the database this is a required field
                if (txtLastNameGuest3.Text != String.Empty)
                {
                    objRs.Fields["LastNameGuest3"].Value = txtLastNameGuest3.Text;
                }
                else
                {
                    objRs.Fields["LastNameGuest3"].Value = String.Empty;
                }

                //Guest4
                // add the captured text into the FirstNameGuest4 field of the database this is a required field
                if (txtFirstNameGuest4.Text != String.Empty)
                {
                    objRs.Fields["FirstNameGuest4"].Value = txtFirstNameGuest4.Text;
                }
                else
                {
                    objRs.Fields["FirstNameGuest4"].Value = String.Empty;
                }

                // add the captured text into the MiddleInitialGuest4 field of the database this is a required field
                if (txtMiddleInitialGuest4.Text != String.Empty)
                {
                    objRs.Fields["MiddleInitialGuest4"].Value = txtMiddleInitialGuest4.Text;
                }
                else
                {
                    objRs.Fields["MiddleInitialGuest4"].Value = String.Empty;
                }

                // add the captured text into the LastNameGuest4 field of the database this is a required field
                if (txtLastNameGuest4.Text != String.Empty)
                {
                    objRs.Fields["LastNameGuest4"].Value = txtLastNameGuest4.Text;
                }
                else
                {
                    objRs.Fields["LastNameGuest4"].Value = String.Empty;
                }

                // check that either checkbox is checked.  If it is, the FamilyConfirmation field becomes 1
                // if it is not, then it becomes 0.  This is a required field if something is typed into the first name of guest 1.
                if(ConfirmFamily.Checked == true)
                {
                    objRs.Fields["FamilyConfirmation"].Value = 1;
                }
                else if(ConfirmFamily.Checked == false)
                {
                    objRs.Fields["FamilyConfirmation"].Value = 0;
                }

                // check that either the yes or no radio buttons are checked.  If it is, the FirstAPAConvention field becomes 1
                // if it is not, then it becomes 0.  This is a required field.
                if(FirstAPAConventionYes.Checked == true)
                {
                    objRs.Fields["FirstAPAConvention"].Value = 1;
                }
                else if(FirstAPAConventionNo.Checked == false)
                {
                    objRs.Fields["FirstAPAConvention"].Value = 0;
                }

                // check that either the yes or no radio buttons are checked.  If it is, the MailProgramBook field becomes 1
                // if it is not, then it becomes 0.  This is a required field.
                if(MailProgramBookYes.Checked == true)
                {
                    objRs.Fields["MailProgramBook"].Value = 1;
                }
                else if(MailProgramBookNo.Checked == false)
                {
                    objRs.Fields["MailProgramBook"].Value = 0;
                }

                // check that either the yes or no radio buttons are checked.  If it is, the EarlyCareerPsychologist field becomes 1
                // if it is not, then it becomes 0.  This is a required field.
                if(EarlyCareerPsychologistYes.Checked == true)
                {
                    objRs.Fields["EarlyCareerPsychologist"].Value = 1;
                }
                else if(EarlyCareerPsychologistNo.Checked == false)
                {
                    objRs.Fields["EarlyCareerPsychologist"].Value = 0;
                }

                // add the selected dropdown to the MembershipCode field in the database.  This is a required field.
                objRs.Fields["MembershipCode"].Value = MembershipDropDownList.SelectedValue;

                // add the captured text into the InstitutionName field of the database this is a required field
                objRs.Fields["InstitutionName"].Value = txtInstitutionName.Text;

                // add the captured text into the InstitutionCity field of the database this is a required field
                objRs.Fields["InstitutionCity"].Value = txtInstitutionCity.Text;

                // add the captured text into the InstitutionStateProvince field of the database this is a required field
                objRs.Fields["InstitutionStateProvince"].Value = txtInstitutionStateProvince.Text;

                // add the captured text into the InstitutionCountry field of the database this is a required field
                objRs.Fields["InstitutionCountry"].Value = txtInstitutionCountry.Text;

                // add the selected dropdown to the InstitutionCode field in the database.  This is a required field.
                objRs.Fields["InstitutionCode"].Value = InstitutionalCodeDropDownList.SelectedValue;

                // create a datetime stamp
                objRs.Fields["DateTimeCreated"].Value = DateTime.Now;

                // save the record to the database
                objRs.Update();

                // close the connection to the database
                objRs.Close();
                objConnect.Close();

                // destroy the objects
                objRs = null;
                objConnect = null;

                return true;
            }
            catch(Exception)
            {
                //throw
                return false;
            }
        }

        protected void cmdSubmit_Click(object sender, EventArgs e)
        {
            if(VerifyForm() == true)
            {
                if(AddRegistration() == true)
                {
                    // send email message
                    SendMail();

                    // redirect to the thank you page
                    Response.Redirect("ThankYou.aspx");
                }
                else
                {
                    //redirect to the error page
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void cmdCancel_Click(object sender, EventArgs e)
        {
            // redirect to the American Psychology Association website
            Response.Redirect("https://www.apa.org/");
        }

        private Boolean VerifyForm()
        {
            if(txtAPAMemberNumber.Text == String.Empty)
            {
                ShowMessage("Please enter your APA Member Number.");
                txtAPAMemberNumber.Focus();
                return false;
            }
            else if(txtNamePrefix.Text == String.Empty)
            {
                ShowMessage("Please enter your name prefix.");
                txtNamePrefix.Focus();
                return false;
            }
            else if(txtFirstName.Text == String.Empty)
            {
                ShowMessage("Please enter your first name.");
                txtFirstName.Focus();
                return false;
            }
            else if(txtLastName.Text == String.Empty)
            {
                ShowMessage("Please enter your last name.");
                txtLastName.Focus();
                return false;
            }
            else if(txtAddress1.Text == String.Empty)
            {
                ShowMessage("Please enter your address.");
                txtAddress1.Focus();
                return false;
            }
            else if(txtStateProvince.Text == String.Empty)
            {
                ShowMessage("Please enter your state or province.");
                txtStateProvince.Focus();
                return false;
            }
            else if(txtZipPostalCode.Text == String.Empty)
            {
                ShowMessage("Please enter your Zip or Postal code.");
                txtZipPostalCode.Focus();
                return false;
            }
            else if(txtCountry.Text == String.Empty)
            {
                ShowMessage("Please enter your country.");
                txtCountry.Focus();
                return false;
            }
            else if(txtPhoneNumber1.Text == String.Empty)
            {
                ShowMessage("Please enter your phone number.");
                txtPhoneNumber1.Focus();
                return false;
            }
            else if(txtEmailAddress.Text == String.Empty)
            {
                ShowMessage("Please enter your Email address.");
                txtEmailAddress.Focus();
                return false;
            }
            else if(DisabilityYes.Checked == false && DisabilityNo.Checked == false)
            {
                ShowMessage("Please answer if you have a disability or not.");
                DisabilityNo.Focus();
                return false;
            }
            else if(txtFirstNameGuest1.Text != String.Empty && ConfirmFamily.Checked == false)
            {
                ShowMessage("Please confirm that the guest(s) specified are your family members.");
                ConfirmFamily.Focus();
                return false;
            }
            else if(FirstAPAConventionYes.Checked == false && FirstAPAConventionNo.Checked == false)
            {
                ShowMessage("Please answer if this is your first APA Convention or not.");
                FirstAPAConventionNo.Focus();
                return false;
            }
            else if(MailProgramBookYes.Checked == false && MailProgramBookNo.Checked == false)
            {
                ShowMessage("Please answer if you would like a program book mailed to you or not.");
                MailProgramBookNo.Focus();
                return false;
            }
            else if(EarlyCareerPsychologistYes.Checked == false && EarlyCareerPsychologistNo.Checked == false)
            {
                ShowMessage("Please answer if you are an early career psychologist or not.");
                EarlyCareerPsychologistNo.Focus();
                return false;
            }
            else if(MembershipDropDownList.SelectedValue == String.Empty)
            {
                ShowMessage("Please select your membership from the drop down list.");
                MembershipDropDownList.Focus();
                return false;
            }
            else if(txtInstitutionName.Text == String.Empty)
            {
                ShowMessage("Please enter the name of your institution.");
                txtInstitutionName.Focus();
                return false;
            }
            else if (txtInstitutionCity.Text == String.Empty)
            {
                ShowMessage("Please enter the city where your institution resides.");
                txtInstitutionCity.Focus();
                return false;
            }
            else if (txtInstitutionStateProvince.Text == String.Empty)
            {
                ShowMessage("Please enter the state/province where your institution resides.");
                txtInstitutionStateProvince.Focus();
                return false;
            }
            else if (txtInstitutionCountry.Text == String.Empty)
            {
                ShowMessage("Please enter the country where your institution resides.");
                txtInstitutionCountry.Focus();
                return false;
            }
            else if (InstitutionalCodeDropDownList.SelectedValue == String.Empty)
            {
                ShowMessage("Please select your institutional code from the drop down list.");
                InstitutionalCodeDropDownList.Focus();
                return false;
            }
            else
                return true;
        }

        private void SendMail()
        {
            try
            {
                // build the email message
                System.Net.Mail.MailMessage objMailMessage = new System.Net.Mail.MailMessage();

                objMailMessage.From = new System.Net.Mail.MailAddress(txtEmailAddress.Text);
                objMailMessage.To.Add("rwlovett@gmail.com");
            objMailMessage.CC.Add(txtEmailAddress.Text);
                objMailMessage.Subject = "MIT 543 Registration Submission";
                objMailMessage.IsBodyHtml = true;

                objMailMessage.Body += "The following information has been submitted via the registration form:<br/><br/>";
                objMailMessage.Body += "Personal Information " + "<br/>";
                objMailMessage.Body += "APA Member Number: " + txtAPAMemberNumber.Text + "<br/>";
                objMailMessage.Body += "Name: " + txtNamePrefix.Text + " " + txtFirstName.Text + " " + txtMiddleInitial.Text + " "+ txtLastName.Text + "<br/>";
                objMailMessage.Body += "Address: " + txtAddress1.Text + "<br/>";
                objMailMessage.Body += "Address2: " + txtAddress2.Text + "<br/>";
                objMailMessage.Body += "City, State/Province, Zip/Postal Code, Country: "; 
                objMailMessage.Body += txtCity.Text + " " + txtStateProvince.Text + " " + txtZipPostalCode.Text + " " + txtCountry.Text + "<br/>";
                objMailMessage.Body += "Phone1: " + txtPhoneNumber1.Text + "<br/>";
                objMailMessage.Body += "Phone2: " + txtPhoneNumber2.Text + "<br/>";
                objMailMessage.Body += "E-mail: " + txtEmailAddress.Text + "<br/><br/>";

                if(DisabilityYes.Checked == true)
                {
                    objMailMessage.Body += "Has Disability?: " + "Yes: " + txtDisability.Text + "<br/><br/>";
                }
                else
                {
                    objMailMessage.Body += "Has Disability?: " + "No " + "<br/><br/>";
                }

                objMailMessage.Body += "Guest Information " + "<br/>";
                objMailMessage.Body += "Guest 1 " + "<br/>";
                objMailMessage.Body += "Name: " + txtFirstNameGuest1.Text + " " + txtMiddleInitialGuest1.Text + " " + txtLastNameGuest1.Text + "<br/><br/>";

                objMailMessage.Body += "Guest 2 " + "<br/>";
                objMailMessage.Body += "Name: " + txtFirstNameGuest2.Text + " " + txtMiddleInitialGuest2.Text + " " + txtLastNameGuest2.Text + "<br/><br/>";

                objMailMessage.Body += "Guest 3 " + "<br/>";
                objMailMessage.Body += "Name: " + txtFirstNameGuest3.Text + " " + txtMiddleInitialGuest3.Text + " " + txtLastNameGuest3.Text + "<br/><br/>";

                objMailMessage.Body += "Guest 4 " + "<br/>";
                objMailMessage.Body += "Name: " + txtFirstNameGuest4.Text + " " + txtMiddleInitialGuest4.Text + " " + txtLastNameGuest4.Text + "<br/><br/>";

                if (ConfirmFamily.Checked == true)
                {
                    objMailMessage.Body += "Confirmed Family?: " + "Yes " + "<br/><br/>";
                }
                else
                {
                    objMailMessage.Body += "Confirmed Family?: " + "No " + "<br/><br/>";
                }

                if (FirstAPAConventionYes.Checked == true)
                {
                    objMailMessage.Body += "First APA Convention?: " + "Yes " + "<br/><br/>";
                }
                else
                {
                    objMailMessage.Body += "First APA Convention?: " + "No " + "<br/><br/>";
                }

                if (MailProgramBookYes.Checked == true)
                {
                    objMailMessage.Body += "Mail Program Book?: " + "Yes " + "<br/><br/>";
                }
                else
                {
                    objMailMessage.Body += "Mail Program Book?: " + "No " + "<br/><br/>";
                }

                if (EarlyCareerPsychologistYes.Checked == true)
                {
                    objMailMessage.Body += "Early Career Psychologist?: " + "Yes " + "<br/><br/>";
                }
                else
                {
                    objMailMessage.Body += "Early Career Psychologist?: " + "No " + "<br/><br/>";
                }

                objMailMessage.Body += "Membership Code: " + MembershipDropDownList.SelectedValue + "<br/>";

                objMailMessage.Body += "Institution Information " + "<br/>";
                objMailMessage.Body += "Institution Name: " + txtInstitutionName.Text + "<br/>";
                objMailMessage.Body += "Institution City, State/Province, Country: " + txtInstitutionName.Text + " " + txtInstitutionCity.Text; 
                objMailMessage.Body += " " + txtInstitutionStateProvince.Text + " " + txtInstitutionCountry.Text + "<br/>";

                objMailMessage.Body += "Institution Code: " + InstitutionalCodeDropDownList.SelectedValue + "<br/>";


                // send the email message
                System.Net.Mail.SmtpClient objSmtpClient = new System.Net.Mail.SmtpClient("relay.elmhurst.edu");
                objSmtpClient.Port = 25;
                objSmtpClient.Send(objMailMessage);

                // destroy the objects
                objSmtpClient = null;
                objMailMessage = null;
            }

            catch
            {
                // redirect to the error page
                Response.Redirect("Error.aspx");
            }
        }
        private void ShowMessage(String MessageToDisplay)
        {
            // define the name and type of the client script
            String csName = "PopupScript";
            Type csType = this.GetType();

            // get a ClientScriptManager object
            System.Web.UI.ClientScriptManager cs = Page.ClientScript;

            // check to see if the startup script is already registered
            if (!cs.IsStartupScriptRegistered(csType, csName))
            {
                String csText = "alert('" + MessageToDisplay + "');";
                cs.RegisterStartupScript(csType, csName, csText, true);
            }
        }

    }
}
