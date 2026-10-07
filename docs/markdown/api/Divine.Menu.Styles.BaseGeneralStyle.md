# <a id="Divine_Menu_Styles_BaseGeneralStyle"></a> Class BaseGeneralStyle

Namespace: [Divine.Menu.Styles](Divine.Menu.Styles.md)  
Assembly: Divine.dll  

```csharp
public class BaseGeneralStyle : IGeneralStyle, IStyle
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[BaseGeneralStyle](Divine.Menu.Styles.BaseGeneralStyle.md)

#### Derived

[GeneralStyle](Divine.Menu.Styles.Default.GeneralStyle.md)

#### Implements

[IGeneralStyle](Divine.Menu.Styles.IGeneralStyle.md), 
[IStyle](Divine.Menu.Styles.IStyle.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<BaseGeneralStyle\>\(BaseGeneralStyle, params BaseGeneralStyle\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Menu_Styles_BaseGeneralStyle__ctor"></a> BaseGeneralStyle\(\)

```csharp
public BaseGeneralStyle()
```

## Properties

### <a id="Divine_Menu_Styles_BaseGeneralStyle_BackgroundBlur"></a> BackgroundBlur

```csharp
public virtual float BackgroundBlur { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_BackgroundBlurRefreshRate"></a> BackgroundBlurRefreshRate

```csharp
public virtual int BackgroundBlurRefreshRate { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_BackgroundOpacity"></a> BackgroundOpacity

```csharp
public virtual float BackgroundOpacity { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_Opacity"></a> Opacity

```csharp
public virtual float Opacity { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_Scale"></a> Scale

```csharp
public virtual float Scale { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_ScrollSteps"></a> ScrollSteps

```csharp
[ScaleFloor(false)]
public virtual float ScrollSteps { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_ShadowBlur"></a> ShadowBlur

```csharp
public virtual float ShadowBlur { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_ShadowOpacity"></a> ShadowOpacity

```csharp
public virtual float ShadowOpacity { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_ShowOpacityProgress"></a> ShowOpacityProgress

```csharp
public virtual float ShowOpacityProgress { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="Divine_Menu_Styles_BaseGeneralStyle_WindowExtraSize"></a> WindowExtraSize

```csharp
[ScaleFloor(false)]
public virtual float WindowExtraSize { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="Divine_Menu_Styles_BaseGeneralStyle_LoadResources"></a> LoadResources\(\)

```csharp
protected virtual void LoadResources()
```

