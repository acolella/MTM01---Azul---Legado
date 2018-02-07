using System;
using System.Collections.Generic;
using SilkTest.Ntf;
using Silk.KeywordDriven;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilkTest.Ntf.XBrowser;

public class Login_Inválido
{

    private readonly Desktop _desktop = Agent.Desktop;

    [Keyword("Login Invalido")]
    public void Login_Invalido()
    {
        BrowserApplication webBrowser = _desktop.BrowserApplication("voeazul_com_br");

        BrowserWindow browserWindow = webBrowser.BrowserWindow("BrowserWindow");
        browserWindow.DomTextField("login-username").SetText("298429128009");
        browserWindow.DomTextField("password").SetText("123456");
        browserWindow.DomButton("OK2").Click();
        Assert.AreEqual("dialog-0003__message dialog-0003__message--small", browserWindow.DomElement("Se o seu login usual").GetProperty("class"));
        Silk4NET.VerifyAsset("Imagem Exclamação");
        Assert.AreEqual(true, browserWindow.DomElement("Atenção!").Visible);
        Assert.AreEqual("Atenção!", browserWindow.DomElement("Atenção!").Text);
        Assert.AreEqual("dialog-0003__title", browserWindow.DomElement("Atenção!").GetProperty("class"));
        Silk4NET.VerifyAsset("Botão OK Vermelho");
        Assert.AreEqual(true, browserWindow.DomButton("OK").Visible);
        Assert.AreEqual("OK", browserWindow.DomButton("OK").Text);
        Assert.AreEqual("button-0001 skin-0085", browserWindow.DomButton("OK").GetProperty("class"));
        browserWindow.DomButton("OK").Click();
        Assert.AreEqual("username", browserWindow.DomTextField("login-username").GetProperty("name"));
        Assert.AreEqual(true, browserWindow.DomTextField("login-username").Visible);
    }

}