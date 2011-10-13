<%@taglib prefix="template" uri="/WEB-INF/tlds/TemplateLibrary" %>

<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>
      <template:get name="title"/>
    </title>
  </head>
  <body>
    <table width="600" border="1" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td align="center">
          <template:get name="header"/>
        </td>
      </tr>
      <tr>
        <td>
          <table width="100%" border="1" cellspacing="0" cellpadding="0">
            <tr>
              <td width="20%" align="center" valign="top">
                <template:get name="left"/>
              </td>
              <td align="center" valign="top">
                <template:get name="main-content"/>
              </td>
              <td width="20%" align="center" valign="top">
                <template:get name="right"/>
              </td>
            </tr>
          </table>
        </td>
      </tr>
      <tr>
        <td align="center" valign="top">
          <template:get name="footer"/>
        </td>
      </tr>
    </table>
  </body>
</html>
