<%@ Page Language="VB" AutoEventWireup="false"  MasterPageFile="~/OCCProject.Master" CodeFile="ProjectWebForm.aspx.vb" Inherits="ProjectWebForm" %>
<%-- Oakland Community College Project
     Developer: Mateo Ortiz Date: 3/3/2023
     ASP.NET Web Form (.aspx)--%>
<%-- WEB FORM --%>
<asp:Content ID="BodyContent" ContentPlaceHolderID="WebFormContent" runat="server">
    <asp:ScriptManager ID="ScriptManager2" runat="server">
    </asp:ScriptManager>
    <%-- BREADCRUMB --%>
        <nav role="navigation">
            <ul class="breadcrumbs">
                <li><a href="Default">Home</a></li>
                <li>OCC Project</li>
            </ul>
        </nav>
    <%-- END BREADCRUMB --%>

    <%-- CONTENT --%>
    <div class="small-12 medium-8 large-8 columns">
        <div class="row">
            <h1 class="page_title">COVID-19 Pandemic</h1>
            <p style="margin-bottom: 6px;">Due to the COVID-19 pandemic, <a href="https://www.oaklandcc.edu/registration/" title="OCC Registration" target="blank">Oakland Community College's Office</a> of the Registrar is working remotely. 
            Please email us or view additional student resources on <a href="https://www.oaklandcc.edu/coronavirus/" title="Coronavirus" target="blank">OCC's COVID-19 Updates and FAQs</a> page. We appreciate your patience during this time. 
            </p>    
        </div>
        <div class="row">
            <h4>Procedure for Graduation</h4>
            <p>The requirements for graduation may be completed during any semester, but the degree or certificate would be conferred 
            following the conclusion of the semester in which the degree or certificate is being awarded. Individual programs may hold additional award events.
            To be eligible for a diploma or certificate, the student must complete all of the following requirements:</p>
            <ul>
                <li>Complete all academic requirements of the degree or certificate program sought.</li>
                <li>File a properly and completely executed Application for Graduation. Graduation applications for a desired semester must be completed before the next semester begins.</li>
                <li>Fulfill all financial obligations to the College.
                    Financial Aid recipients must clear the <a href="https://www.oaklandcc.edu/finaid/" title="Finacial Aid" target="blank">Office of Financial Aid’s</a> special requirements for exiting students.</li>
            </ul>
            <p>Multiple awards may be issued simultaneously; however, students must meet the eligibility and procedural standards for each award.</p>
        </div>
    </div> 
    <aside class="small-12 medium-3 medium-offset-1 large-3 large-offset-1 columns block--related-links">
                            <!--ZOOMSTOP-->
                            <h2 class="block__title">Related Links</h2>
                            <p class="block__subtitle">Oakland Community College Project</p>
                                                                                    <ul class="block__link-list">
                                        <li style="list-style-type: none"><a title="CORONAVIRUS (COVID-19)" href="https://www.oaklandcc.edu/coronavirus/">
                                            CORONAVIRUS (COVID-19)</a></li>
                                        <li style="list-style-type: none"><a title="COVID-19 BEHAVIORS" href="https://www.oaklandcc.edu/coronavirus/behavior">
                                            COVID-19 BEHAVIORS</a></li>
                                        <li style="list-style-type: none"><a title="COVID RELIEF FUNDING" href="https://www.oaklandcc.edu/coronavirus/relief-fund">
                                            COVID RELIEF FUNDING</a></li>
                                        <li style="list-style-type: none"><a title="STUDENT SERVICE" href="https://www.oaklandcc.edu/currentstudents/#services">
                                            STUDENT SERVICE</a></li>
                                        <li style="list-style-type: none"><a title="FEDERAL EMERGENCY" href="https://www.oaklandcc.edu/about/transparency-at-occ/cares-act">
                                            FEDERAL EMERGENCY</a></li>
                                        <li style="list-style-type: none"><a title="OFFICE OF THE REGISTRA" href="https://www.oaklandcc.edu/registration/">
                                            OFFICE OF THE REGISTRA</a></li>
                        </ul>
                            <!--ZOOMRESTART-->
                            </aside>
    <div class="row">
       <div class="small-12 medium-6 columns">
           <p class="required">* Required</p>
           <%-- END CONTENT --%>

           <%-- ALERTS --%>
           <p><asp:Label ID="Success_Message" runat="server" CssClass="alert-box success radius"
                Visible="false">"Your request for information was successfully submitted!"
                <a href="#" class="close">&times;</a>
            </asp:Label></p>
           <p><asp:Label ID="Error_Message" runat="server" CssClass="alert-box radius"
               Text ="" Visible="false">
               Oops! It's not your fault, but a Critical Error has occurred.
               <a href="#" class="close">&times;</a>
            </asp:Label></p> 
           <%-- END ALERTS --%>

           <%-- FORM --%>
            <table>
               <thead>
                   <tr>
                       <td><h3 class="subformheader">Student Information</h3></td>
                   </tr>
               </thead>
               <tbody>
                   <tr>
                       <td>
                            <div class="row rowmargin10">
                                <div class="small-12 columns">
                                <label for="FirstNameTextBox" id="FirstNameLabel" name="FirstNameLabel">
                                        First Name <span class="required">*</span>
                                        
                                        <asp:RequiredFieldValidator 
                                           ID="RequiredFieldValidator1" 
                                           runat="server"
                                           ControlToValidate="FirstNameTextBox"
                                           ErrorMessage="Required."
                                           ForeColor="Red"></asp:RequiredFieldValidator>

                                        <asp:RegularExpressionValidator 
                                           ID="RegularExpressionValidator2" runat="server"                                               
                                           ControlToValidate="FirstNameTextBox"
                                           ErrorMessage="Remove special characters (hyphens, apostrophes, etc.)"
                                           ValidationExpression="^[a-zA-Z]+$"
                                           ForeColor="Red"></asp:RegularExpressionValidator>
                                       
                                         <asp:TextBox ID ="FirstNameTextBox" name="FirstNameTextBox" ToolTip="First Name" type="text" maxlength="50" runat="server"></asp:TextBox>
                                </label>
                                </div>
                            </div>
                            <div class="row rowmargin10">
                                <div class="small-12 columns">
                                <label for="LastNameTextBox" id="LastNameLabel" name="LastNameLabel">
                                        Last Name <span class="required">*</span>
                     
                                        <asp:RequiredFieldValidator 
                                           ID="RequiredFieldValidator2" runat="server"
                                           ControlToValidate="LastNameTextBox"
                                           ErrorMessage="Required."
                                           ForeColor="Red"></asp:RequiredFieldValidator>

                                        <asp:RegularExpressionValidator 
                                           ID="RegularExpressionValidator3" runat="server"
                                           ControlToValidate="LastNameTextBox"
                                           ErrorMessage="Remove special characters (hyphens, apostrophes, etc.)"
                                           ValidationExpression="^[a-zA-Z]+$"
                                           ForeColor="Red"></asp:RegularExpressionValidator>

                                        <asp:TextBox ID ="LastNameTextBox" name="LastNameTextBox" ToolTip="Last Name" type="text" maxlength="50" runat="server"></asp:TextBox>
                                </label>
                                </div>
                            </div>
                            <div class="row rowmargin10">
                                <div class="small-12 columns">
                                <label for="PhoneTextBox" ID="PhoneLabel" name="PhoneLabel">
                                        Phone <span class="required">*</span>
                             
                                        <asp:RequiredFieldValidator 
                                           ID="RequiredFieldValidator5" runat="server"
                                           ControlToValidate="PhoneTextBox"
                                           ErrorMessage="Required."
                                           ForeColor="Red"></asp:RequiredFieldValidator>

                                        <asp:RegularExpressionValidator 
                                           ID="RegularExpressionValidator1" runat="server"
                                           ControlToValidate="PhoneTextBox"
                                           ErrorMessage="Enter a phone number in xxx-xxx-xxxx format."
                                           ValidationExpression="\d{3}-\d{3}-\d{4}"
                                           ForeColor="Red"></asp:RegularExpressionValidator>

                                        <asp:TextBox ID="PhoneTextBox" PlaceHolder="XXX-XXX-XXXX" ToolTip="Phone" name="PhoneTextBoxName" type="text" maxlength="20"  title="Phone" runat="server" ></asp:TextBox>
                                </label>
                                </div>
                            </div> 
                            <div class="row rowmargin10">
                                <div class="small-12 columns">
                                <label for="EmailTextBox" id="EmailLabel" name="EmailLabel">
                                        Email <span class="required">*</span>
                        
                                        <asp:RequiredFieldValidator 
                                           ID="RequiredFieldValidator4" runat="server"
                                           ControlToValidate="EmailTextBox"
                                           ErrorMessage="Required."
                                           ForeColor="Red"></asp:RequiredFieldValidator>

                                        <asp:RegularExpressionValidator 
                                           ID="Email_RegularExpressionValidator" runat="server"
                                           ControlToValidate="EmailTextBox"
                                           ErrorMessage="Enter a valid email address."
                                           ValidationExpression="\b[A-Za-z0-9._%+-]+@[A_Za-z0-9.-]+\.[a-z]{2,}\b"
                                           ForeColor="Red"></asp:RegularExpressionValidator>

                                        <asp:TextBox ID="EmailTextBox" name="EmailTextBox" ToolTip="Email" type="text" maxlength="50" title="Email" runat="server"></asp:TextBox>
                                </label>
                                </div>
                            </div> 
                        </td>
                    </tr>
                    <tr>
                        <td style="background-color: #fff">
                            <div class="text-center" style="border-top: 1px solid #c0c0c0; padding: 18px;">
                                <asp:Button type="submit" value="Submit" ID="InsertButton"  name="InsertButton" runat="server" Text="Submit"  class="button occ-button"/>
                                <asp:Button type="submit" value="Cancel" ID="InsertCancelButton" OnClientClick="DoPostBack" name="InsertCancelButton" runat="server" Text="Cancel"  class="button "/>
                                <caption align="Top">OCC Request Form</caption>
                            </div> 
                        </td>
                    </tr>
                </tbody>
            </table>
           <%-- END FORM --%>
        </div>
    </div>
    <%-- JAVASCRIPT --%>
     <script> 
         $(".close").on('click', () => {$('.alert-box').remove()});
     </script>
    <%-- END JAVASCRIPT --%>
</asp:Content>
<%-- END WEB FORM --%>

