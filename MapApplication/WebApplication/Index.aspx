<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>百度地图</title>
    <link type="text/css" href="/Content/Site.css" rel="stylesheet" />
    <script type="text/javascript" src="/Scripts/jquery-1.12.1.js"></script>
    <script type="text/javascript" src="http://api.map.baidu.com/api?v=2.0&ak=s3GCVjiafgN9mAoLU2UGmYpyVTWltG2R"></script>
    <script type="text/javascript" src="http://api.map.baidu.com/library/TextIconOverlay/1.2/src/TextIconOverlay_min.js"></script>
	<script type="text/javascript" src="http://api.map.baidu.com/library/MarkerClusterer/1.2/src/MarkerClusterer_min.js"></script>
</head>
<body>
    <div id="baiduMap" class="map"></div>

    <textarea name="message" rows="2" style="display:none;"></textarea>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Scripts>
                <asp:ScriptReference Path="~/Scripts/main.js" />
            </Scripts>
            <Services>
                <asp:ServiceReference Path="~/WebService.asmx" />
            </Services>
        </asp:ScriptManager>
    </form>

</body>
</html>
