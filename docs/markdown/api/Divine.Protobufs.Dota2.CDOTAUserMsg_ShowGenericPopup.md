# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup"></a> Class CDOTAUserMsg\_ShowGenericPopup

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_ShowGenericPopup : IMessage<CDOTAUserMsg_ShowGenericPopup>, IEquatable<CDOTAUserMsg_ShowGenericPopup>, IDeepCloneable<CDOTAUserMsg_ShowGenericPopup>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_ShowGenericPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowGenericPopup.md)

#### Implements

IMessage<CDOTAUserMsg\_ShowGenericPopup\>, 
[IEquatable<CDOTAUserMsg\_ShowGenericPopup\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_ShowGenericPopup\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_ShowGenericPopup\>\(CDOTAUserMsg\_ShowGenericPopup, params CDOTAUserMsg\_ShowGenericPopup\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup__ctor"></a> CDOTAUserMsg\_ShowGenericPopup\(\)

```csharp
public CDOTAUserMsg_ShowGenericPopup()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_"></a> CDOTAUserMsg\_ShowGenericPopup\(CDOTAUserMsg\_ShowGenericPopup\)

```csharp
public CDOTAUserMsg_ShowGenericPopup(CDOTAUserMsg_ShowGenericPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShowGenericPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowGenericPopup.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_BodyFieldNumber"></a> BodyFieldNumber

```csharp
public const int BodyFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HeaderFieldNumber"></a> HeaderFieldNumber

```csharp
public const int HeaderFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Param1FieldNumber"></a> Param1FieldNumber

```csharp
public const int Param1FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Param2FieldNumber"></a> Param2FieldNumber

```csharp
public const int Param2FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ShowNoOtherDialogsFieldNumber"></a> ShowNoOtherDialogsFieldNumber

```csharp
public const int ShowNoOtherDialogsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_TintScreenFieldNumber"></a> TintScreenFieldNumber

```csharp
public const int TintScreenFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Body"></a> Body

```csharp
public string Body { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HasBody"></a> HasBody

```csharp
public bool HasBody { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HasHeader"></a> HasHeader

```csharp
public bool HasHeader { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HasParam1"></a> HasParam1

```csharp
public bool HasParam1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HasParam2"></a> HasParam2

```csharp
public bool HasParam2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HasShowNoOtherDialogs"></a> HasShowNoOtherDialogs

```csharp
public bool HasShowNoOtherDialogs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_HasTintScreen"></a> HasTintScreen

```csharp
public bool HasTintScreen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Header"></a> Header

```csharp
public string Header { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Param1"></a> Param1

```csharp
public string Param1 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Param2"></a> Param2

```csharp
public string Param2 { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_ShowGenericPopup> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_ShowGenericPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowGenericPopup.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ShowNoOtherDialogs"></a> ShowNoOtherDialogs

```csharp
public bool ShowNoOtherDialogs { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_TintScreen"></a> TintScreen

```csharp
public bool TintScreen { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ClearBody"></a> ClearBody\(\)

```csharp
public void ClearBody()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ClearHeader"></a> ClearHeader\(\)

```csharp
public void ClearHeader()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ClearParam1"></a> ClearParam1\(\)

```csharp
public void ClearParam1()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ClearParam2"></a> ClearParam2\(\)

```csharp
public void ClearParam2()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ClearShowNoOtherDialogs"></a> ClearShowNoOtherDialogs\(\)

```csharp
public void ClearShowNoOtherDialogs()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ClearTintScreen"></a> ClearTintScreen\(\)

```csharp
public void ClearTintScreen()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_ShowGenericPopup Clone()
```

#### Returns

 [CDOTAUserMsg\_ShowGenericPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowGenericPopup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_"></a> Equals\(CDOTAUserMsg\_ShowGenericPopup\)

```csharp
public bool Equals(CDOTAUserMsg_ShowGenericPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShowGenericPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowGenericPopup.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_"></a> MergeFrom\(CDOTAUserMsg\_ShowGenericPopup\)

```csharp
public void MergeFrom(CDOTAUserMsg_ShowGenericPopup other)
```

#### Parameters

`other` [CDOTAUserMsg\_ShowGenericPopup](Divine.Protobufs.Dota2.CDOTAUserMsg\_ShowGenericPopup.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_ShowGenericPopup_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

