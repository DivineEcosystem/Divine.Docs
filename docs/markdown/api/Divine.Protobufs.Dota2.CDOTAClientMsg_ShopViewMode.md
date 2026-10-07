# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode"></a> Class CDOTAClientMsg\_ShopViewMode

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ShopViewMode : IMessage<CDOTAClientMsg_ShopViewMode>, IEquatable<CDOTAClientMsg_ShopViewMode>, IDeepCloneable<CDOTAClientMsg_ShopViewMode>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ShopViewMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_ShopViewMode.md)

#### Implements

IMessage<CDOTAClientMsg\_ShopViewMode\>, 
[IEquatable<CDOTAClientMsg\_ShopViewMode\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ShopViewMode\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ShopViewMode\>\(CDOTAClientMsg\_ShopViewMode, params CDOTAClientMsg\_ShopViewMode\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode__ctor"></a> CDOTAClientMsg\_ShopViewMode\(\)

```csharp
public CDOTAClientMsg_ShopViewMode()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_"></a> CDOTAClientMsg\_ShopViewMode\(CDOTAClientMsg\_ShopViewMode\)

```csharp
public CDOTAClientMsg_ShopViewMode(CDOTAClientMsg_ShopViewMode other)
```

#### Parameters

`other` [CDOTAClientMsg\_ShopViewMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_ShopViewMode.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_ModeFieldNumber"></a> ModeFieldNumber

```csharp
public const int ModeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_HasMode"></a> HasMode

```csharp
public bool HasMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_Mode"></a> Mode

```csharp
public uint Mode { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ShopViewMode> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ShopViewMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_ShopViewMode.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_ClearMode"></a> ClearMode\(\)

```csharp
public void ClearMode()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ShopViewMode Clone()
```

#### Returns

 [CDOTAClientMsg\_ShopViewMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_ShopViewMode.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_"></a> Equals\(CDOTAClientMsg\_ShopViewMode\)

```csharp
public bool Equals(CDOTAClientMsg_ShopViewMode other)
```

#### Parameters

`other` [CDOTAClientMsg\_ShopViewMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_ShopViewMode.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_"></a> MergeFrom\(CDOTAClientMsg\_ShopViewMode\)

```csharp
public void MergeFrom(CDOTAClientMsg_ShopViewMode other)
```

#### Parameters

`other` [CDOTAClientMsg\_ShopViewMode](Divine.Protobufs.Dota2.CDOTAClientMsg\_ShopViewMode.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ShopViewMode_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

