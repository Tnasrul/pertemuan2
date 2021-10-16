@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "About"

    Dim kalimat As String = "Ini adalah contoh"
    Dim angka As Integer = 7
    Dim desimal As Double = 3.15
    Dim hasil As Double = angka * desimal

End Code

<hgroup class="title">
    <h1>@PageData("Title").</h1>
    <h2>Your app description page.</h2>
</hgroup>

<article>
    <p>
        Use this area to provide additional information.
    </p>

    <p>
        Use this area to provide additional information.
    </p>

    <p>
        Use this area to provide additional information.
    </p>
    <p>
        @kalimat
    </p>
    <p>
        @angka
    </p>
    <p>
        @desimal
    </p>
    <p>
        @hasil
    </p>
</article>

<aside>
    <h3>Aside Title</h3>
    <p>
        Use this area to provide additional information.
    </p>
    <ul>
        <li><a href="~/">Home</a></li>
        <li><a href="~/About">About</a></li>
        <li><a href="~/Contact">Contact</a></li>
    </ul>
</aside>