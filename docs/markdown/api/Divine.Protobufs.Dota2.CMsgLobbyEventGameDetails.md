# <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails"></a> Class CMsgLobbyEventGameDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyEventGameDetails : IMessage<CMsgLobbyEventGameDetails>, IEquatable<CMsgLobbyEventGameDetails>, IDeepCloneable<CMsgLobbyEventGameDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyEventGameDetails](Divine.Protobufs.Dota2.CMsgLobbyEventGameDetails.md)

#### Implements

IMessage<CMsgLobbyEventGameDetails\>, 
[IEquatable<CMsgLobbyEventGameDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyEventGameDetails\>, 
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
[EnumerableExtensions.In<CMsgLobbyEventGameDetails\>\(CMsgLobbyEventGameDetails, params CMsgLobbyEventGameDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails__ctor"></a> CMsgLobbyEventGameDetails\(\)

```csharp
public CMsgLobbyEventGameDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails__ctor_Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_"></a> CMsgLobbyEventGameDetails\(CMsgLobbyEventGameDetails\)

```csharp
public CMsgLobbyEventGameDetails(CMsgLobbyEventGameDetails other)
```

#### Parameters

`other` [CMsgLobbyEventGameDetails](Divine.Protobufs.Dota2.CMsgLobbyEventGameDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_KvDataFieldNumber"></a> KvDataFieldNumber

```csharp
public const int KvDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_HasKvData"></a> HasKvData

```csharp
public bool HasKvData { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_KvData"></a> KvData

```csharp
public ByteString KvData { get; set; }
```

#### Property Value

 ByteString

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyEventGameDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyEventGameDetails](Divine.Protobufs.Dota2.CMsgLobbyEventGameDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_ClearKvData"></a> ClearKvData\(\)

```csharp
public void ClearKvData()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyEventGameDetails Clone()
```

#### Returns

 [CMsgLobbyEventGameDetails](Divine.Protobufs.Dota2.CMsgLobbyEventGameDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_Equals_Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_"></a> Equals\(CMsgLobbyEventGameDetails\)

```csharp
public bool Equals(CMsgLobbyEventGameDetails other)
```

#### Parameters

`other` [CMsgLobbyEventGameDetails](Divine.Protobufs.Dota2.CMsgLobbyEventGameDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_"></a> MergeFrom\(CMsgLobbyEventGameDetails\)

```csharp
public void MergeFrom(CMsgLobbyEventGameDetails other)
```

#### Parameters

`other` [CMsgLobbyEventGameDetails](Divine.Protobufs.Dota2.CMsgLobbyEventGameDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventGameDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

