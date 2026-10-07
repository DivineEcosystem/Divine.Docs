# <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember"></a> Class CSODOTAStaticLobbyMember

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSODOTAStaticLobbyMember : IMessage<CSODOTAStaticLobbyMember>, IEquatable<CSODOTAStaticLobbyMember>, IDeepCloneable<CSODOTAStaticLobbyMember>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)

#### Implements

IMessage<CSODOTAStaticLobbyMember\>, 
[IEquatable<CSODOTAStaticLobbyMember\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSODOTAStaticLobbyMember\>, 
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
[EnumerableExtensions.In<CSODOTAStaticLobbyMember\>\(CSODOTAStaticLobbyMember, params CSODOTAStaticLobbyMember\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember__ctor"></a> CSODOTAStaticLobbyMember\(\)

```csharp
public CSODOTAStaticLobbyMember()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember__ctor_Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_"></a> CSODOTAStaticLobbyMember\(CSODOTAStaticLobbyMember\)

```csharp
public CSODOTAStaticLobbyMember(CSODOTAStaticLobbyMember other)
```

#### Parameters

`other` [CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_CameramanFieldNumber"></a> CameramanFieldNumber

```csharp
public const int CameramanFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_ChannelFieldNumber"></a> ChannelFieldNumber

```csharp
public const int ChannelFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_PartyIdFieldNumber"></a> PartyIdFieldNumber

```csharp
public const int PartyIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Cameraman"></a> Cameraman

```csharp
public bool Cameraman { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Channel"></a> Channel

```csharp
public uint Channel { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_HasCameraman"></a> HasCameraman

```csharp
public bool HasCameraman { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_HasChannel"></a> HasChannel

```csharp
public bool HasChannel { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_HasPartyId"></a> HasPartyId

```csharp
public bool HasPartyId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Parser"></a> Parser

```csharp
public static MessageParser<CSODOTAStaticLobbyMember> Parser { get; }
```

#### Property Value

 MessageParser<[CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)\>

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_PartyId"></a> PartyId

```csharp
public ulong PartyId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_ClearCameraman"></a> ClearCameraman\(\)

```csharp
public void ClearCameraman()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_ClearChannel"></a> ClearChannel\(\)

```csharp
public void ClearChannel()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_ClearPartyId"></a> ClearPartyId\(\)

```csharp
public void ClearPartyId()
```

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Clone"></a> Clone\(\)

```csharp
public CSODOTAStaticLobbyMember Clone()
```

#### Returns

 [CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_Equals_Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_"></a> Equals\(CSODOTAStaticLobbyMember\)

```csharp
public bool Equals(CSODOTAStaticLobbyMember other)
```

#### Parameters

`other` [CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_MergeFrom_Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_"></a> MergeFrom\(CSODOTAStaticLobbyMember\)

```csharp
public void MergeFrom(CSODOTAStaticLobbyMember other)
```

#### Parameters

`other` [CSODOTAStaticLobbyMember](Divine.Protobufs.Dota2.CSODOTAStaticLobbyMember.md)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSODOTAStaticLobbyMember_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

