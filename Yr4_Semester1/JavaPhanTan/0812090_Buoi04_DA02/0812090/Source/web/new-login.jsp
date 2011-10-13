<%@taglib prefix="template" uri="/WEB-INF/tlds/TemplateLibrary" %>

<template:insert template="templates/NewTemplate.jsp">
   <template:put name="title" content="User login" direct="true"/>
   <template:put name="header" content="subs/header.jsp" direct="false"/>
   <template:put name="content" content="subs/content-login.jsp" direct="false"/>
   <template:put name="footer" content="subs/footer.jsp" direct="false"/>
   <template:put name="banner" content="subs/banner.jsp" direct="false"/>
   <template:put name="misc" content="subs/misc-login.jsp" direct="false"/>
</template:insert>