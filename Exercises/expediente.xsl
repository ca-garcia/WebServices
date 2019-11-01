<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">
<html>
<body>
<h2>Expediente academico</h2>
<h3>Alumno: <xsl:value-of select="expediente/@alumno"/></h3>
<table border="1">
<tr bgcolor="#9acd32"><th align="left">Asignatura</th><th align="left">Nota</th></tr>
<xsl:for-each select="expediente/asignatura">
<xsl:sort select="nombre"/>
<xsl:if test="nota &gt; 2">
<xsl:choose>
<xsl:when test="nota &lt; 4">
<tr>
<td>
<font color="#ff0000">
<xsl:value-of select="nombre"/>
</font>
</td>
<td><font color="#ff0000">
<xsl:value-of select="nota"/>
</font>
</td>
</tr>
</xsl:when>
<xsl:otherwise>
<tr>
<td><xsl:value-of select="nombre"/></td>
<td><xsl:value-of select="nota"/></td>
</tr>
</xsl:otherwise>
</xsl:choose>
</xsl:if>
</xsl:for-each>
</table>
</body>
</html>
</xsl:template>
</xsl:stylesheet>
