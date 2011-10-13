<%--
    Document   : Page-1
    Created on : Oct 31, 2010, 5:30:20 PM
    Author     : nXqd
--%>

<%@taglib prefix="template" uri="/WEB-INF/tlds/TemplateLibrary" %>

<template:insert template="templates/NewTemplate.jsp">
   <template:put name="title" content="World of Refridge" direct="true"/>
   <template:put name="head" content="subs/head.jsp" direct="false"/>
   <template:put name="header" content="subs/header.jsp" direct="false"/>
   <template:put name="content" content="subs/content-index.jsp" direct="false"/>
   <template:put name="footer" content="subs/footer.jsp" direct="false"/>
   <template:put name="banner" content="subs/banner.jsp" direct="false"/>
   <template:put name="misc" content="subs/misc-index.jsp" direct="false"/>
</template:insert>
