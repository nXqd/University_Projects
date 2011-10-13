<%--
This handles when you click search button
--%>

<script>
    $("#RegisterButton").click(function() {
        var searchStr = $('#searchBox').val();
        window.location.href = "index.jsp?searchStr=" + searchStr;
    });
</script>
