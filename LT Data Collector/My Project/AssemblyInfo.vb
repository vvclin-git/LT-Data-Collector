Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Globalization
Imports System.Resources
Imports System.Windows

' 組件的一般資訊是由下列的屬性集控制。
' 變更這些屬性的值即可修改組件的相關
' 資訊。

' 檢閱組件屬性的值

<Assembly: AssemblyTitle("LT_Data_Collector")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("Microsoft")>
<Assembly: AssemblyProduct("LT_Data_Collector")>
<Assembly: AssemblyCopyright("Copyright © Microsoft 2016")>
<Assembly: AssemblyTrademark("")>
<Assembly: ComVisible(false)>

'為了建置可當地語系化的應用程式，請設定 
'.vbproj 檔案中 <PropertyGroup> 內的
'<UICulture>CultureYouAreCodingWith</UICulture>。例如，如果原始程式檔使用美式英文， 
'請將 <UICulture> 設為 "en-US"。然後取消註解
'下列 NeutralResourceLanguage 屬性。更新下一行中的 "en-US"，
'以符合專案檔中的 UICulture 設定。

'<Assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)> 


'ThemeInfo 屬性描述任何主題特定和泛型資源字典的位置。
'第 1 個參數: 主題特定資源字典的位置
'(用於頁面中找不到資源時， 
' 或應用程式資源字典中找不到資源時)

'第 2 個參數: 泛型資源字典的位置
'(用於頁面中找不到資源時， 
'以及應用程式和任何主題特定資源字典中找不到資源時)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>



'下列 GUID 為專案公開 (Expose) 至 COM 時所要使用的 typelib ID
<Assembly: Guid("9876d404-66ec-4b12-b81a-306e36352308")>

' 組件的版本資訊由下列四個值所組成: 
'
'      主要版本
'      次要版本
'      組建編號
'      修訂編號
'
' 您可以指定所有的值，也可以依照以下的方式，使用 '*' 將組建和修訂編號
' 指定為預設值: 
' <Assembly: AssemblyVersion("1.0.*")> 

<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
