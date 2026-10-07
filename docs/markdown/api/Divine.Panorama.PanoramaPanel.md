# <a id="Divine_Panorama_PanoramaPanel"></a> Class PanoramaPanel

Namespace: [Divine.Panorama](Divine.Panorama.md)  
Assembly: Divine.dll  

```csharp
public sealed class PanoramaPanel : PanoramaNode, IDisposable
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[PanoramaNode](Divine.Panorama.PanoramaNode.md) ← 
[PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[PanoramaNode.Kind](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Kind), 
[PanoramaNode.TypeName](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_TypeName), 
[PanoramaNode.ConstructorName](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ConstructorName), 
[PanoramaNode.IsPanel](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsPanel), 
[PanoramaNode.IsObject](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsObject), 
[PanoramaNode.IsArray](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsArray), 
[PanoramaNode.IsNull](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_IsNull), 
[PanoramaNode.Dispose\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Dispose), 
[PanoramaNode.GetValue<T\>\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_GetValue\_\_1), 
[PanoramaNode.GetValue<T\>\(string\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_GetValue\_\_1\_System\_String\_), 
[PanoramaNode.SetValue<T\>\(string, T\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_SetValue\_\_1\_System\_String\_\_\_0\_), 
[PanoramaNode.Get\(string\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Get\_System\_String\_), 
[PanoramaNode.GetMembers\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_GetMembers), 
[PanoramaNode.Invoke<T\>\(string, params object?\[\]\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Invoke\_\_1\_System\_String\_System\_Object\_\_\_), 
[PanoramaNode.Invoke\(string, params object?\[\]\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_Invoke\_System\_String\_System\_Object\_\_\_), 
[PanoramaNode.ToJson\(bool, bool\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ToJson\_System\_Boolean\_System\_Boolean\_), 
[PanoramaNode.ToJsonNode\(bool\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ToJsonNode\_System\_Boolean\_), 
[PanoramaNode.ToString\(\)](Divine.Panorama.PanoramaNode.md\#Divine\_Panorama\_PanoramaNode\_ToString), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<PanoramaPanel\>\(PanoramaPanel, params PanoramaPanel\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Properties

### <a id="Divine_Panorama_PanoramaPanel_AcceptsFocus"></a> AcceptsFocus

```csharp
public bool AcceptsFocus { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_AcceptsInput"></a> AcceptsInput

```csharp
public bool AcceptsInput { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_ActualLayoutHeight"></a> ActualLayoutHeight

```csharp
public float ActualLayoutHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ActualLayoutWidth"></a> ActualLayoutWidth

```csharp
public float ActualLayoutWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ActualUiScaleX"></a> ActualUiScaleX

```csharp
public float ActualUiScaleX { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ActualUiScaleY"></a> ActualUiScaleY

```csharp
public float ActualUiScaleY { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ActualXOffset"></a> ActualXOffset

```csharp
public float ActualXOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ActualYOffset"></a> ActualYOffset

```csharp
public float ActualYOffset { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_Checked"></a> Checked

```csharp
public bool Checked { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_ContentHeight"></a> ContentHeight

```csharp
public float ContentHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ContentWidth"></a> ContentWidth

```csharp
public float ContentWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_DefaultFocus"></a> DefaultFocus

```csharp
public string DefaultFocus { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_DesiredLayoutHeight"></a> DesiredLayoutHeight

```csharp
public float DesiredLayoutHeight { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_DesiredLayoutWidth"></a> DesiredLayoutWidth

```csharp
public float DesiredLayoutWidth { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_Enabled"></a> Enabled

```csharp
public bool Enabled { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_HitTest"></a> HitTest

```csharp
public bool HitTest { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_HitTestChildren"></a> HitTestChildren

```csharp
public bool HitTestChildren { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_Id"></a> Id

```csharp
public string Id { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_InputNamespace"></a> InputNamespace

```csharp
public string InputNamespace { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_IsDraggable"></a> IsDraggable

```csharp
public bool IsDraggable { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_LayoutFile"></a> LayoutFile

```csharp
public string LayoutFile { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_Native"></a> Native

```csharp
public nint Native { get; }
```

#### Property Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="Divine_Panorama_PanoramaPanel_PanelType"></a> PanelType

```csharp
public string PanelType { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_ReadyForDisplay"></a> ReadyForDisplay

```csharp
public bool ReadyForDisplay { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_RememberChildFocus"></a> RememberChildFocus

```csharp
public bool RememberChildFocus { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_ScrollOffsetX"></a> ScrollOffsetX

```csharp
public float ScrollOffsetX { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ScrollOffsetY"></a> ScrollOffsetY

```csharp
public float ScrollOffsetY { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_ScrollParentToFitWhenFocused"></a> ScrollParentToFitWhenFocused

```csharp
public bool ScrollParentToFitWhenFocused { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_SelectionPositionX"></a> SelectionPositionX

```csharp
public float? SelectionPositionX { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="Divine_Panorama_PanoramaPanel_SelectionPositionY"></a> SelectionPositionY

```csharp
public float? SelectionPositionY { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="Divine_Panorama_PanoramaPanel_Style"></a> Style

```csharp
public PanoramaStyle Style { get; }
```

#### Property Value

 [PanoramaStyle](Divine.Panorama.PanoramaStyle.md)

### <a id="Divine_Panorama_PanoramaPanel_TabIndex"></a> TabIndex

```csharp
public float? TabIndex { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)?

### <a id="Divine_Panorama_PanoramaPanel_Type"></a> Type

```csharp
public string Type { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_Visible"></a> Visible

```csharp
public bool Visible { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Panorama_PanoramaPanel_AddClass_System_String_"></a> AddClass\(string\)

```csharp
public void AddClass(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_AddClasses_System_String___"></a> AddClasses\(params string\[\]\)

```csharp
public void AddClasses(params string[] classNames)
```

#### Parameters

`classNames` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_Panorama_PanoramaPanel_ApplyStyles_System_Boolean_"></a> ApplyStyles\(bool\)

```csharp
public void ApplyStyles(bool immediate)
```

#### Parameters

`immediate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_AscendantHasClass_System_String_"></a> AscendantHasClass\(string\)

```csharp
public bool AscendantHasClass(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_CanSeeInParentScroll"></a> CanSeeInParentScroll\(\)

```csharp
public bool CanSeeInParentScroll()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_Children"></a> Children\(\)

```csharp
public PanoramaPanel[] Children()
```

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)\[\]

### <a id="Divine_Panorama_PanoramaPanel_ClearPanelEvent_System_String_"></a> ClearPanelEvent\(string\)

```csharp
public void ClearPanelEvent(string eventName)
```

#### Parameters

`eventName` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_ClearPropertyFromCode_System_String_"></a> ClearPropertyFromCode\(string\)

```csharp
public void ClearPropertyFromCode(string property)
```

#### Parameters

`property` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_Data_System_Object___"></a> Data\(params object?\[\]\)

```csharp
public PanoramaNode Data(params object?[] args)
```

#### Parameters

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaPanel_DeleteAsync_System_Single_"></a> DeleteAsync\(float\)

```csharp
public void DeleteAsync(float delay)
```

#### Parameters

`delay` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_FindAncestor_System_String_"></a> FindAncestor\(string\)

```csharp
public PanoramaPanel? FindAncestor(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_FindChild_System_String_"></a> FindChild\(string\)

```csharp
public PanoramaPanel? FindChild(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_FindChildInLayoutFile_System_String_"></a> FindChildInLayoutFile\(string\)

```csharp
public PanoramaPanel? FindChildInLayoutFile(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_FindChildrenWithAttributeTraverse_System_String_"></a> FindChildrenWithAttributeTraverse\(string\)

```csharp
public PanoramaPanel[] FindChildrenWithAttributeTraverse(string attributeName)
```

#### Parameters

`attributeName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)\[\]

### <a id="Divine_Panorama_PanoramaPanel_FindChildrenWithClassTraverse_System_String_"></a> FindChildrenWithClassTraverse\(string\)

```csharp
public PanoramaPanel[] FindChildrenWithClassTraverse(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)\[\]

### <a id="Divine_Panorama_PanoramaPanel_FindChildTraverse_System_String_"></a> FindChildTraverse\(string\)

```csharp
public PanoramaPanel? FindChildTraverse(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_FindPanelInThisOrParentLayoutFile_System_String_"></a> FindPanelInThisOrParentLayoutFile\(string\)

```csharp
public PanoramaPanel? FindPanelInThisOrParentLayoutFile(string id)
```

#### Parameters

`id` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_GetAttributeInt_System_String_System_Int32_"></a> GetAttributeInt\(string, int\)

```csharp
public int GetAttributeInt(string name, int defaultValue)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`defaultValue` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Panorama_PanoramaPanel_GetAttributeString_System_String_System_String_"></a> GetAttributeString\(string, string\)

```csharp
public string GetAttributeString(string name, string defaultValue)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`defaultValue` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_GetAttributeUInt32_System_String_System_UInt32_"></a> GetAttributeUInt32\(string, uint\)

```csharp
public uint GetAttributeUInt32(string name, uint defaultValue)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`defaultValue` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

#### Returns

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Panorama_PanoramaPanel_GetChild_System_Int32_"></a> GetChild\(int\)

```csharp
public PanoramaPanel? GetChild(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_GetChildCount"></a> GetChildCount\(\)

```csharp
public int GetChildCount()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Panorama_PanoramaPanel_GetChildIndex_Divine_Panorama_PanoramaPanel_"></a> GetChildIndex\(PanoramaPanel\)

```csharp
public int GetChildIndex(PanoramaPanel child)
```

#### Parameters

`child` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Panorama_PanoramaPanel_GetClasses"></a> GetClasses\(\)

```csharp
public string[] GetClasses()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_Panorama_PanoramaPanel_GetParent"></a> GetParent\(\)

```csharp
public PanoramaPanel? GetParent()
```

#### Returns

 [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)?

### <a id="Divine_Panorama_PanoramaPanel_GetPosition_System_Boolean_"></a> GetPosition\(bool\)

```csharp
public PanoramaNode GetPosition(bool includeScroll)
```

#### Parameters

`includeScroll` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaPanel_GetPositionWithinAncestor_Divine_Panorama_PanoramaPanel_"></a> GetPositionWithinAncestor\(PanoramaPanel\)

```csharp
public PanoramaNode GetPositionWithinAncestor(PanoramaPanel ancestor)
```

#### Parameters

`ancestor` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaPanel_GetPositionWithinWindow"></a> GetPositionWithinWindow\(\)

```csharp
public PanoramaNode GetPositionWithinWindow()
```

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaPanel_GetProperties"></a> GetProperties\(\)

```csharp
public Dictionary<string, string> GetProperties()
```

#### Returns

 [Dictionary](https://learn.microsoft.com/dotnet/api/system.collections.generic.dictionary\-2)<[string](https://learn.microsoft.com/dotnet/api/system.string), [string](https://learn.microsoft.com/dotnet/api/system.string)\>

### <a id="Divine_Panorama_PanoramaPanel_GetSnippetNames"></a> GetSnippetNames\(\)

```csharp
public PanoramaNode GetSnippetNames()
```

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaPanel_GetStyleFile_System_Int32_"></a> GetStyleFile\(int\)

```csharp
public string? GetStyleFile(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)?

### <a id="Divine_Panorama_PanoramaPanel_GetStyleFileSymbol_System_Int32_"></a> GetStyleFileSymbol\(int\)

```csharp
public ushort GetStyleFileSymbol(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [ushort](https://learn.microsoft.com/dotnet/api/system.uint16)

### <a id="Divine_Panorama_PanoramaPanel_HasClass_System_String_"></a> HasClass\(string\)

```csharp
public bool HasClass(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_HasDescendantKeyFocus"></a> HasDescendantKeyFocus\(\)

```csharp
public bool HasDescendantKeyFocus()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_HasHoverStyle"></a> HasHoverStyle\(\)

```csharp
public bool HasHoverStyle()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_HasKeyFocus"></a> HasKeyFocus\(\)

```csharp
public bool HasKeyFocus()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_HasLayoutSnippet_System_String_"></a> HasLayoutSnippet\(string\)

```csharp
public bool HasLayoutSnippet(string snippet)
```

#### Parameters

`snippet` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_IsSelected"></a> IsSelected\(\)

```csharp
public bool IsSelected()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_IsSizeValid"></a> IsSizeValid\(\)

```csharp
public bool IsSizeValid()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_IsTransparent"></a> IsTransparent\(\)

```csharp
public bool IsTransparent()
```

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_LoadLayout_System_String_System_Boolean_System_Boolean_"></a> LoadLayout\(string, bool, bool\)

```csharp
public bool LoadLayout(string path, bool overrideExisting, bool partial)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

`overrideExisting` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`partial` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_LoadLayoutSnippet_System_String_"></a> LoadLayoutSnippet\(string\)

```csharp
public bool LoadLayoutSnippet(string snippet)
```

#### Parameters

`snippet` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_MoveChildAfter_Divine_Panorama_PanoramaPanel_Divine_Panorama_PanoramaPanel_"></a> MoveChildAfter\(PanoramaPanel, PanoramaPanel\)

```csharp
public void MoveChildAfter(PanoramaPanel child, PanoramaPanel after)
```

#### Parameters

`child` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

`after` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

### <a id="Divine_Panorama_PanoramaPanel_MoveChildBefore_Divine_Panorama_PanoramaPanel_Divine_Panorama_PanoramaPanel_"></a> MoveChildBefore\(PanoramaPanel, PanoramaPanel\)

```csharp
public void MoveChildBefore(PanoramaPanel child, PanoramaPanel before)
```

#### Parameters

`child` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

`before` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

### <a id="Divine_Panorama_PanoramaPanel_PlayPanelSound_System_String_"></a> PlayPanelSound\(string\)

```csharp
public void PlayPanelSound(string sound)
```

#### Parameters

`sound` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_RegisterForReadyEvents_System_Boolean_"></a> RegisterForReadyEvents\(bool\)

```csharp
public void RegisterForReadyEvents(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_RemoveAndDeleteChildren"></a> RemoveAndDeleteChildren\(\)

```csharp
public void RemoveAndDeleteChildren()
```

### <a id="Divine_Panorama_PanoramaPanel_RemoveClass_System_String_"></a> RemoveClass\(string\)

```csharp
public void RemoveClass(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_RemoveClasses_System_String___"></a> RemoveClasses\(params string\[\]\)

```csharp
public void RemoveClasses(params string[] classNames)
```

#### Parameters

`classNames` [string](https://learn.microsoft.com/dotnet/api/system.string)\[\]

### <a id="Divine_Panorama_PanoramaPanel_RunScriptInPanelContext_System_Object___"></a> RunScriptInPanelContext\(params object?\[\]\)

```csharp
public PanoramaNode RunScriptInPanelContext(params object?[] args)
```

#### Parameters

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

#### Returns

 [PanoramaNode](Divine.Panorama.PanoramaNode.md)

### <a id="Divine_Panorama_PanoramaPanel_ScrollParentToMakePanelFit_Divine_Panorama_PanoramaPanel_System_Boolean_"></a> ScrollParentToMakePanelFit\(PanoramaPanel, bool\)

```csharp
public void ScrollParentToMakePanelFit(PanoramaPanel panel, bool immediate)
```

#### Parameters

`panel` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

`immediate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_ScrollToBottom"></a> ScrollToBottom\(\)

```csharp
public void ScrollToBottom()
```

### <a id="Divine_Panorama_PanoramaPanel_ScrollToFitRegion_System_Single_System_Single_System_Single_System_Single_Divine_Panorama_PanoramaNode_System_Boolean_System_Boolean_"></a> ScrollToFitRegion\(float, float, float, float, PanoramaNode?, bool, bool\)

```csharp
public void ScrollToFitRegion(float x, float y, float width, float height, PanoramaNode? alignment, bool immediate, bool direct)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

`alignment` [PanoramaNode](Divine.Panorama.PanoramaNode.md)?

`immediate` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

`direct` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_ScrollToLeftEdge"></a> ScrollToLeftEdge\(\)

```csharp
public void ScrollToLeftEdge()
```

### <a id="Divine_Panorama_PanoramaPanel_ScrollToRightEdge"></a> ScrollToRightEdge\(\)

```csharp
public void ScrollToRightEdge()
```

### <a id="Divine_Panorama_PanoramaPanel_ScrollToTop"></a> ScrollToTop\(\)

```csharp
public void ScrollToTop()
```

### <a id="Divine_Panorama_PanoramaPanel_SetAttributeInt_System_String_System_Int32_"></a> SetAttributeInt\(string, int\)

```csharp
public void SetAttributeInt(string name, int value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Panorama_PanoramaPanel_SetAttributeString_System_String_System_String_"></a> SetAttributeString\(string, string\)

```csharp
public void SetAttributeString(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_SetAttributeUInt32_System_String_System_UInt32_"></a> SetAttributeUInt32\(string, uint\)

```csharp
public void SetAttributeUInt32(string name, uint value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Panorama_PanoramaPanel_SetCompositionLayerTextureName_System_String_"></a> SetCompositionLayerTextureName\(string\)

```csharp
public void SetCompositionLayerTextureName(string name)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_SetDialogVariable_System_String_System_String_"></a> SetDialogVariable\(string, string\)

```csharp
public void SetDialogVariable(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_SetDialogVariableInt_System_String_System_Int32_"></a> SetDialogVariableInt\(string, int\)

```csharp
public void SetDialogVariableInt(string name, int value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Panorama_PanoramaPanel_SetDialogVariableLocString_System_String_System_String_"></a> SetDialogVariableLocString\(string, string\)

```csharp
public void SetDialogVariableLocString(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_SetDialogVariableLocStringNested_System_String_System_String_"></a> SetDialogVariableLocStringNested\(string, string\)

```csharp
public void SetDialogVariableLocStringNested(string name, string value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_SetDialogVariableTime_System_String_System_Int64_"></a> SetDialogVariableTime\(string, long\)

```csharp
public void SetDialogVariableTime(string name, long value)
```

#### Parameters

`name` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [long](https://learn.microsoft.com/dotnet/api/system.int64)

### <a id="Divine_Panorama_PanoramaPanel_SetDisableFocusOnMouseDown_System_Boolean_"></a> SetDisableFocusOnMouseDown\(bool\)

```csharp
public void SetDisableFocusOnMouseDown(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_SetFocus"></a> SetFocus\(\)

```csharp
public void SetFocus()
```

### <a id="Divine_Panorama_PanoramaPanel_SetHasClass_System_String_System_Boolean_"></a> SetHasClass\(string, bool\)

```csharp
public void SetHasClass(string className, bool value)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_SetHeightInPixels_System_Single_"></a> SetHeightInPixels\(float\)

```csharp
public void SetHeightInPixels(float height)
```

#### Parameters

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_SetPanelEvent_System_Object___"></a> SetPanelEvent\(params object?\[\]\)

```csharp
public void SetPanelEvent(params object?[] args)
```

#### Parameters

`args` [object](https://learn.microsoft.com/dotnet/api/system.object)?\[\]

### <a id="Divine_Panorama_PanoramaPanel_SetParent_Divine_Panorama_PanoramaPanel_"></a> SetParent\(PanoramaPanel\)

```csharp
public void SetParent(PanoramaPanel parent)
```

#### Parameters

`parent` [PanoramaPanel](Divine.Panorama.PanoramaPanel.md)

### <a id="Divine_Panorama_PanoramaPanel_SetPositionInPixels_System_Single_System_Single_System_Single_"></a> SetPositionInPixels\(float, float, float\)

```csharp
public void SetPositionInPixels(float x, float y, float z)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`z` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_SetSendScrollPositionChangedEvents_System_Boolean_"></a> SetSendScrollPositionChangedEvents\(bool\)

```csharp
public void SetSendScrollPositionChangedEvents(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_SetTopOfInputContext_System_Boolean_"></a> SetTopOfInputContext\(bool\)

```csharp
public void SetTopOfInputContext(bool value)
```

#### Parameters

`value` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Panorama_PanoramaPanel_SetWidthInPixels_System_Single_"></a> SetWidthInPixels\(float\)

```csharp
public void SetWidthInPixels(float width)
```

#### Parameters

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Panorama_PanoramaPanel_SwitchClass_System_String_System_String_"></a> SwitchClass\(string, string\)

```csharp
public void SwitchClass(string attributeName, string className)
```

#### Parameters

`attributeName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_ToggleClass_System_String_"></a> ToggleClass\(string\)

```csharp
public void ToggleClass(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_TriggerClass_System_String_"></a> TriggerClass\(string\)

```csharp
public void TriggerClass(string className)
```

#### Parameters

`className` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Panorama_PanoramaPanel_UpdateFocusInContext"></a> UpdateFocusInContext\(\)

```csharp
public void UpdateFocusInContext()
```

### <a id="Divine_Panorama_PanoramaPanel_WriteCompositionLayerPng_System_String_"></a> WriteCompositionLayerPng\(string\)

```csharp
public void WriteCompositionLayerPng(string path)
```

#### Parameters

`path` [string](https://learn.microsoft.com/dotnet/api/system.string)

