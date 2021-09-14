<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <form id='frmCoordonnees' action="Default.aspx" method="get" enctype="multipart/form-data">

        <p>
            <label for='rdSexe'>
                Sexe :</label>
            <input name="rdSexe" value="H" checked="checked" type="radio" />Homme
            <input name="rdSexe" value="F" type="radio" />Femme
        </p>
        <p>
            <label for='txtNom'>
                Nom :</label>
            <input id="txtNom" type="text" name="nom" />

        </p>
        <p>
            <label for='txtPrenom'>
                Prénom :</label>
            <input id="txtPrenom" type="text" name="prenom" />

        </p>

        <p>
            <label for='txtAdresse_P1'>
                Adresse :</label>
            <input id="txtAdresse_P1" type="text" />

        </p>
        <p id='pAdresse_P2'>
            <label for='txtAdresse_P2'>
                ..</label>
            <input id="txtAdresse_P2" type="text" />
        </p>
        <p>
            <label for='txtCodePostal'>
                Code Postal Ville:</label>
            <input id="txtCodePostal" type="text" name="codepostal" />
            <input id="txtVille" type="text" />
        </p>
        <p>
            <label for='selPays'>
                Pays :</label>
            <select id="selPays">
                <option value="fr">France</option>
                <option value="us">US</option>
            </select>
        </p>


        <p>
            <label for='txtMail'>
                Adresse mail :</label>
            <input id="txtMail" type="email" />
        </p>
        <p>
            <label for='txtTelephone'>
                Téléphone :</label>
            <input id="txtTelephone" type="text" name="tel" />
        </p>
        <p>
            <label>
                Date de naissance :</label>
            <input id="txtDateNaissance" type="date" />
        </p>

        <p>
            Vos centres d'intérets
            <input name="chkInterets" value="BR" type="checkbox" />Bricolage
            <input name="chkInterets" value="JD" type="checkbox" />Jardinage
            <input name="chkInterets" value="LC" type="checkbox" />Lecture
            <input name="chkInterets" value="VG" type="checkbox" />Voyages
        </p>
        <p>
            <input id='btnEnvoyer' value="Envoyer" type="submit" />
        </p>

    </form>

</asp:Content>
