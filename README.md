# MSGraphHackTogether
This Application connects Microsoft Graph API &amp; Displays Teams Users Status

<h4>1.Connect with Microsoft Identity Platform</h4>
Every app that uses Azure AD for authentication must be registered with Azure AD. For your .NET core MVC web app, you may connect your app with Microsoft Identity Platform through Visual Studio 2022. Please follow the instructions to connect your app with Microsoft Identity Platform:

<ul>
<li>Clone the MSGraphHackTogether repository to your local workspace or directly download the source code.</li>
<li>Open the project folder MSGraphHackTogether and double click to MSGraph.sln file to open your project with Visual Studio.</li>
<li>Select Connected Services from the project root, and then direct to Connected Services tab, select three dots icon next to Microsoft identity platform</li>
</ul>


![image](https://user-images.githubusercontent.com/46391548/225508591-83c3ae11-7243-4b2a-9229-7befe9cd642c.png)

![image](https://user-images.githubusercontent.com/46391548/225509074-f9e515f8-1eb2-4272-a1f8-3c6d0f1f2feb.png)


<li>Login with your developer account and select your tenant. Give a name for your app and then select Register.</li>
<li>Make sure to select Add Microsoft Graph permissions and select Next.</li>
<li>Select Local user secret file: Secret.json(local), then select Next.</li>
<h4> 2. Run your .NET Core MVC web app</h4>
Select https run button to start your app on your machine.
When your .NET Core MVC web app initiates, log in with your developer account.

After the login, you'll see your email address mentioned on navigation bar of your app & displays user details as below</h4>

<img width="943" alt="image" src="https://user-images.githubusercontent.com/46391548/225506277-75569391-ef0f-4892-b743-6c79ae62e53d.png">

<h4>Reference</h4>
https://github.com/PabloVenino/hack-together/tree/main/templates/dotnet-core-mvc-web-app-microsoft-graph#minimal-path-to-awesome-
