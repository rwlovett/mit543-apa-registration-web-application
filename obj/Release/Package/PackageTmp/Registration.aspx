<%@ Page Title="American Psychological Association Registration" Language="C#" MasterPageFile="/FinalExam/FinalMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Registration.Registration" %>
<asp:Content ID="RegistrationContent" ContentPlaceHolderID="MasterContentPlaceHolder" runat="server">
<table width="422" cellspacing="0" cellpadding="0" border="0" align="center">
    <tr>
        <td>
            <table>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><h2>Personal Information</h2></td>
                </tr>
                <tr>
                    <td>APA Member Number:</td>
                    <td><asp:TextBox ID="txtAPAMemberNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Prefix: </td>
                    <td><asp:TextBox ID="txtNamePrefix" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Middle Initial:</td>
                    <td><asp:TextBox ID="txtMiddleInitial" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address1:</td>
                    <td><asp:TextBox ID="txtAddress1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address2:</td>
                    <td><asp:TextBox ID="txtAddress2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>State/Province:</td>
                    <td><asp:TextBox ID="txtStateProvince" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Zip/Postal Code:</td>
                    <td><asp:TextBox ID="txtZipPostalCode" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Country:</td>
                    <td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone Number1:</td>
                    <td><asp:TextBox ID="txtPhoneNumber1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Phone Number2:</td>
                    <td><asp:TextBox ID="txtPhoneNumber2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email Address:</td>
                    <td><asp:TextBox ID="txtEmailAddress" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Do you have a disability?:</td>
                    <td align="center"><asp:RadioButton ID="DisabilityYes" runat="server" Text="Yes" GroupName="Disability"/>
                        <asp:RadioButton ID="DisabilityNo" runat="server" Text="No" GroupName="Disability"/></td>
                </tr>
                <tr>
                    <td>If yes, please indicate your disability:</td>
                    <td><asp:TextBox ID="txtDisability" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><h4>Guest Information</h4></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><p>Nonmember Nonpsychologist Spouse/Equivalent or Dependent(s) Under Age 18 requiring a badge.</p></td>
                </tr>
                <tr>
                    <td><h5>Guest 1</h5></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstNameGuest1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Middle Initial:</td>
                    <td><asp:TextBox ID="txtMiddleInitialGuest1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastNameGuest1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td><h5>Guest 2</h5></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstNameGuest2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Middle Initial:</td>
                    <td><asp:TextBox ID="txtMiddleInitialGuest2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastNameGuest2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td><h5>Guest 3</h5></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstNameGuest3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Middle Initial:</td>
                    <td><asp:TextBox ID="txtMiddleInitialGuest3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastNameGuest3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td><h5>Guest 4</h5></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="txtFirstNameGuest4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Middle Initial:</td>
                    <td><asp:TextBox ID="txtMiddleInitialGuest4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="txtLastNameGuest4" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:CheckBox ID="ConfirmFamily" runat="server" Text=" I confirm that the individuals listed above are family members."/></td>

                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><h4>Convention Questions</h4></td>
                </tr>
                <tr>
                    <td>First APA Convention?:</td>
                    <td align="center"><asp:RadioButton ID="FirstAPAConventionYes" runat="server" Text="Yes" GroupName="FirstAPAConvention"/>
                        <asp:RadioButton ID="FirstAPAConventionNo" runat="server" Text="No" GroupName="FirstAPAConvention"/></td>
                </tr>
                <tr>
                    <td>Mail Program Book?:</td>
                    <td align="center"><asp:RadioButton ID="MailProgramBookYes" runat="server" Text="Yes" GroupName="MailProgramBook"/>
                        <asp:RadioButton ID="MailProgramBookNo" runat="server" Text="No" GroupName="MailProgramBook"/></td>
                </tr>
                <tr>
                    <td>Early Career Psychologist?:</td>
                    <td align="center"><asp:RadioButton ID="EarlyCareerPsychologistYes" runat="server" Text="Yes" GroupName="EarlyCareerPsychologist"/>
                        <asp:RadioButton ID="EarlyCareerPsychologistNo" runat="server" Text="No" GroupName="EarlyCareerPsychologist"/></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><h4>Membership Code</h4></td>
                </tr>
                <tr>
                    <td colspan="5" align="center">
                        <asp:DropDownList ID="MembershipDropDownList" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>APA Member</asp:ListItem>
                            <asp:ListItem>APA Fellow</asp:ListItem>
                            <asp:ListItem>APA Associate</asp:ListItem>
                            <asp:ListItem>Nonmember</asp:ListItem>
                            <asp:ListItem>APA International Affiliate</asp:ListItem>
                            <asp:ListItem>APA Community Collage Teacher Affiliate</asp:ListItem>
                            <asp:ListItem>APA High School Teacher Affiliate</asp:ListItem>
                            <asp:ListItem>APAGS Member</asp:ListItem>
                            <asp:ListItem>APA Student Affiliate</asp:ListItem>
                            <asp:ListItem>Full-Time Student</asp:ListItem>
                            <asp:ListItem>State/Provincial/Territorial Association Representative</asp:ListItem>
                            <asp:ListItem>Nonmember Nonpsychologist Spouse/Equivilants and Dependents under age 18</asp:ListItem>
                        </asp:DropDownList>
                        </br></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><h2>Institution Information</h2></td>
                </tr>
                <tr>
                    <td>Institution Name:</td>
                    <td><asp:TextBox ID="txtInstitutionName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City:</td>
                    <td><asp:TextBox ID="txtInstitutionCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>State/Province:</td>
                    <td><asp:TextBox ID="txtInstitutionStateProvince" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Country:</td>
                    <td><asp:TextBox ID="txtInstitutionCountry" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr>
                    <td colspan="5" align="center"><h4>Institutional Code</h4></td>
                </tr>
                <tr>
                    <td colspan="5">
                        <asp:DropDownList ID="InstitutionalCodeDropDownList" runat="server">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>Universities, Colleges, and Professional Schools</asp:ListItem>
                            <asp:ListItem>Primary and Secondary Schools (Public and Private)</asp:ListItem>
                            <asp:ListItem>Government (Federal, State/Providential, or Local) including all military services</asp:ListItem>
                            <asp:ListItem>Business/Industry</asp:ListItem>
                            <asp:ListItem>Non-Governmental Organizations (Associations or Quasi Governmental or International Organizations)</asp:ListItem>
                            <asp:ListItem>Human (Mental/Health) Services (Hospitals, Clinics, CMHCs)</asp:ListItem>
                            <asp:ListItem>Independent Practice</asp:ListItem>
                            <asp:ListItem>Other Professions (Non-Mental/Health) Services (Research)</asp:ListItem>
                            <asp:ListItem>Other (Retired/Emeritus, Self-Employed except Independent Practice)</asp:ListItem>
                        </asp:DropDownList>
                        </br></td>
                </tr>

                <tr>
                    <td colspan="5"></br></td>
                </tr>
                <tr class="Buttons">
                    <td>
                        <asp:Button ID="cmdSubmit" runat="server" Text="Submit Registration" OnClick="cmdSubmit_Click" />
                    </td>
                    <td>
                        <asp:Button ID="cmdCancel" runat="server" Text="Cancel" OnClick="cmdCancel_Click" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
