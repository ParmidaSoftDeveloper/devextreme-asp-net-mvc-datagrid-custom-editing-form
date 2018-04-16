Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Optimization

Namespace DevExtremeMvcAppGridTest

	Public Class BundleConfig

		Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)

			Dim scriptBundle = New ScriptBundle("~/Scripts/bundle")
			Dim styleBundle = New StyleBundle("~/Content/bundle")

			' jQuery
			scriptBundle.Include("~/Scripts/jquery-2.2.3.js")

			' Bootstrap
			scriptBundle.Include("~/Scripts/bootstrap.js")

			'Script for a custom popup window
			scriptBundle.Include("~/Scripts/customPopup/customPopup.js")

			' Bootstrap
			styleBundle.Include("~/Content/bootstrap.css")

			' Custom site styles
			styleBundle.Include("~/Content/Site.css")

			bundles.Add(scriptBundle)
			bundles.Add(styleBundle)

#If (Not DEBUG) Then
			BundleTable.EnableOptimizations = True
#End If
		End Sub
	End Class
End Namespace