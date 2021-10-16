@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "Form"
End Code

<hgroup class="title">
    <h1>@PageData("Title").</h1>
    <h2>Page Form.</h2>
</hgroup>

<section class="contact">
    <input id="Text1" type="text" />
    <input id="Button1" type="button" value="button" />
</section> 