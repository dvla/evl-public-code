<?xml version="1.0"?>
<!--English Relicence Script Text-->
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
    xmlns:utils="urn:utils" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <xsl:output method="html" indent="yes"/>
  <xsl:param name="step" select="ConfirmVehicle"  />

  <xsl:template match="/">
    <xsl:choose>
      <xsl:when test="$step = 'TaxStep'">
        <xsl:call-template name="TextTextStep" />
      </xsl:when>
      <xsl:otherwise>
        <xsl:call-template name="TechnicalErrorPayments" />
      </xsl:otherwise>
    </xsl:choose>
  </xsl:template>

  <xsl:template name="TextTextStep">
    <xsl:call-template name="TaxTextDisplay" />
    <input type="Hidden" value="TextTextStep" />
  </xsl:template>
  
  <xsl:template name="TechnicalErrorPayments">
    <h2>Technical error</h2>
  </xsl:template>

  <xsl:template name="TaxTextDisplay">

    <div class="start-header group" runat="server" ID="startHeader" clientidmode="Static">
      <h1>
        Example usage
      </h1>
      <p>
        This page is being rendered using our script generator control we have created.
      </p>
      <p>
        Below are a few examples of using the styles contained within this project.
      </p>
    </div>
    <div class="start-container group">
      <div class="application-notice info-notice info-notice-bold">
        <p>
          This is an example of an information notice presented to the user.
        </p>
      </div>
      <div>
        <p>
          <strong>
            <label for="MainContent_txtSearchVrm" id="MainContent_lblVehicleVRN">
              Registration number
            </label>
          </strong>
        </p>
        <p>
          <input name="vehicleRegistrationNumber" type="text" maxlength="8" id="searchVRN" />
        </p>
      </div>
      <p>
        <input type="submit" name="button" value="Button" id="button" class="button" />
      </p>
      <a href="#">This is an example link </a>
      <h2>
        Table example
      </h2>
      <ul class="ul-data" xmlns:utils="urn:utils" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
        <li>
          <span>Vehicle make </span>
          <strong>FORD</strong>
        </li>
        <li>
          <span>Date of first registration </span>
          <strong>01 September 2003</strong>
        </li>
        <li>
          <span>Year of manufacture </span>
          <strong>2003</strong>
        </li>
      </ul>
    </div>

    <input type="hidden" value="TaxTextDisplay" />
  </xsl:template>

</xsl:stylesheet>
