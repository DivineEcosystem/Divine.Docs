# <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses"></a> Class CUserMessageUpdateCssClasses

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageUpdateCssClasses : IMessage<CUserMessageUpdateCssClasses>, IEquatable<CUserMessageUpdateCssClasses>, IDeepCloneable<CUserMessageUpdateCssClasses>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageUpdateCssClasses](Divine.Protobufs.Dota2.CUserMessageUpdateCssClasses.md)

#### Implements

IMessage<CUserMessageUpdateCssClasses\>, 
[IEquatable<CUserMessageUpdateCssClasses\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageUpdateCssClasses\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMessageUpdateCssClasses\>\(CUserMessageUpdateCssClasses, params CUserMessageUpdateCssClasses\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses__ctor"></a> CUserMessageUpdateCssClasses\(\)

```csharp
public CUserMessageUpdateCssClasses()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses__ctor_Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_"></a> CUserMessageUpdateCssClasses\(CUserMessageUpdateCssClasses\)

```csharp
public CUserMessageUpdateCssClasses(CUserMessageUpdateCssClasses other)
```

#### Parameters

`other` [CUserMessageUpdateCssClasses](Divine.Protobufs.Dota2.CUserMessageUpdateCssClasses.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_CssClassesFieldNumber"></a> CssClassesFieldNumber

```csharp
public const int CssClassesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_IsAddFieldNumber"></a> IsAddFieldNumber

```csharp
public const int IsAddFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_TargetWorldPanelFieldNumber"></a> TargetWorldPanelFieldNumber

```csharp
public const int TargetWorldPanelFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_CssClasses"></a> CssClasses

```csharp
public string CssClasses { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_HasCssClasses"></a> HasCssClasses

```csharp
public bool HasCssClasses { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_HasIsAdd"></a> HasIsAdd

```csharp
public bool HasIsAdd { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_HasTargetWorldPanel"></a> HasTargetWorldPanel

```csharp
public bool HasTargetWorldPanel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_IsAdd"></a> IsAdd

```csharp
public bool IsAdd { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageUpdateCssClasses> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageUpdateCssClasses](Divine.Protobufs.Dota2.CUserMessageUpdateCssClasses.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_TargetWorldPanel"></a> TargetWorldPanel

```csharp
public int TargetWorldPanel { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_ClearCssClasses"></a> ClearCssClasses\(\)

```csharp
public void ClearCssClasses()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_ClearIsAdd"></a> ClearIsAdd\(\)

```csharp
public void ClearIsAdd()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_ClearTargetWorldPanel"></a> ClearTargetWorldPanel\(\)

```csharp
public void ClearTargetWorldPanel()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_Clone"></a> Clone\(\)

```csharp
public CUserMessageUpdateCssClasses Clone()
```

#### Returns

 [CUserMessageUpdateCssClasses](Divine.Protobufs.Dota2.CUserMessageUpdateCssClasses.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_Equals_Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_"></a> Equals\(CUserMessageUpdateCssClasses\)

```csharp
public bool Equals(CUserMessageUpdateCssClasses other)
```

#### Parameters

`other` [CUserMessageUpdateCssClasses](Divine.Protobufs.Dota2.CUserMessageUpdateCssClasses.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_MergeFrom_Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_"></a> MergeFrom\(CUserMessageUpdateCssClasses\)

```csharp
public void MergeFrom(CUserMessageUpdateCssClasses other)
```

#### Parameters

`other` [CUserMessageUpdateCssClasses](Divine.Protobufs.Dota2.CUserMessageUpdateCssClasses.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageUpdateCssClasses_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

