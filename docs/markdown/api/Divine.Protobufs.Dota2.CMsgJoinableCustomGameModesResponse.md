# <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse"></a> Class CMsgJoinableCustomGameModesResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgJoinableCustomGameModesResponse : IMessage<CMsgJoinableCustomGameModesResponse>, IEquatable<CMsgJoinableCustomGameModesResponse>, IDeepCloneable<CMsgJoinableCustomGameModesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgJoinableCustomGameModesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponse.md)

#### Implements

IMessage<CMsgJoinableCustomGameModesResponse\>, 
[IEquatable<CMsgJoinableCustomGameModesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgJoinableCustomGameModesResponse\>, 
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
[EnumerableExtensions.In<CMsgJoinableCustomGameModesResponse\>\(CMsgJoinableCustomGameModesResponse, params CMsgJoinableCustomGameModesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse__ctor"></a> CMsgJoinableCustomGameModesResponse\(\)

```csharp
public CMsgJoinableCustomGameModesResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse__ctor_Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_"></a> CMsgJoinableCustomGameModesResponse\(CMsgJoinableCustomGameModesResponse\)

```csharp
public CMsgJoinableCustomGameModesResponse(CMsgJoinableCustomGameModesResponse other)
```

#### Parameters

`other` [CMsgJoinableCustomGameModesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_GameModesFieldNumber"></a> GameModesFieldNumber

```csharp
public const int GameModesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_GameModes"></a> GameModes

```csharp
public RepeatedField<CMsgJoinableCustomGameModesResponseEntry> GameModes { get; }
```

#### Property Value

 RepeatedField<[CMsgJoinableCustomGameModesResponseEntry](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponseEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgJoinableCustomGameModesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgJoinableCustomGameModesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgJoinableCustomGameModesResponse Clone()
```

#### Returns

 [CMsgJoinableCustomGameModesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_Equals_Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_"></a> Equals\(CMsgJoinableCustomGameModesResponse\)

```csharp
public bool Equals(CMsgJoinableCustomGameModesResponse other)
```

#### Parameters

`other` [CMsgJoinableCustomGameModesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_"></a> MergeFrom\(CMsgJoinableCustomGameModesResponse\)

```csharp
public void MergeFrom(CMsgJoinableCustomGameModesResponse other)
```

#### Parameters

`other` [CMsgJoinableCustomGameModesResponse](Divine.Protobufs.Dota2.CMsgJoinableCustomGameModesResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgJoinableCustomGameModesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

