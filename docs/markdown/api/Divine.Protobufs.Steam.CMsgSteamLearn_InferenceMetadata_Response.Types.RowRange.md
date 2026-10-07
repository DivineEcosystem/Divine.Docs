# <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange"></a> Class CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange : IMessage<CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange>, IEquatable<CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange>, IDeepCloneable<CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)

#### Implements

IMessage<CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange\>, 
[IEquatable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange\>, 
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
[EnumerableExtensions.In<CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange\>\(CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange, params CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange__ctor"></a> RowRange\(\)

```csharp
public RowRange()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange__ctor_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_"></a> RowRange\(RowRange\)

```csharp
public RowRange(CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_MaxRowFieldNumber"></a> MaxRowFieldNumber

```csharp
public const int MaxRowFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_MinRowFieldNumber"></a> MinRowFieldNumber

```csharp
public const int MinRowFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_HasMaxRow"></a> HasMaxRow

```csharp
public bool HasMaxRow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_HasMinRow"></a> HasMinRow

```csharp
public bool HasMinRow { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_MaxRow"></a> MaxRow

```csharp
public ulong MaxRow { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_MinRow"></a> MinRow

```csharp
public ulong MinRow { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_ClearMaxRow"></a> ClearMaxRow\(\)

```csharp
public void ClearMaxRow()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_ClearMinRow"></a> ClearMinRow\(\)

```csharp
public void ClearMinRow()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange Clone()
```

#### Returns

 [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_Equals_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_"></a> Equals\(RowRange\)

```csharp
public bool Equals(CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_"></a> MergeFrom\(RowRange\)

```csharp
public void MergeFrom(CMsgSteamLearn_InferenceMetadata_Response.Types.RowRange other)
```

#### Parameters

`other` [CMsgSteamLearn\_InferenceMetadata\_Response](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.md).[Types](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.md).[RowRange](Divine.Protobufs.Steam.CMsgSteamLearn\_InferenceMetadata\_Response.Types.RowRange.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearn_InferenceMetadata_Response_Types_RowRange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

