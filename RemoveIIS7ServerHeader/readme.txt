Add the following line to /configuration/system.WebServer.modules

<add name="CustomHeaderModule" type="RemoveIIS7ServerHeader.CustomHeaderModule" />

like so...

<configuration>
  <system.webServer>
    <modules>
      <add name="CustomHeaderModule" type="RemoveIIS7ServerHeader.CustomHeaderModule" />
    </modules>
  </system.webServer>
</configuration>	