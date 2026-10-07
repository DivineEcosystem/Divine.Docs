# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites"></a> Class CMsgGCToClientPartySearchInvites

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPartySearchInvites : IMessage<CMsgGCToClientPartySearchInvites>, IEquatable<CMsgGCToClientPartySearchInvites>, IDeepCloneable<CMsgGCToClientPartySearchInvites>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)

#### Implements

IMessage<CMsgGCToClientPartySearchInvites\>, 
[IEquatable<CMsgGCToClientPartySearchInvites\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPartySearchInvites\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPartySearchInvites\>\(CMsgGCToClientPartySearchInvites, params CMsgGCToClientPartySearchInvites\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites__ctor"></a> CMsgGCToClientPartySearchInvites\(\)

```csharp
public CMsgGCToClientPartySearchInvites()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_"></a> CMsgGCToClientPartySearchInvites\(CMsgGCToClientPartySearchInvites\)

```csharp
public CMsgGCToClientPartySearchInvites(CMsgGCToClientPartySearchInvites other)
```

#### Parameters

`other` [CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_InvitesFieldNumber"></a> InvitesFieldNumber

```csharp
public const int InvitesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_Invites"></a> Invites

```csharp
public RepeatedField<CMsgGCToClientPartySearchInvite> Invites { get; }
```

#### Property Value

 RepeatedField<[CMsgGCToClientPartySearchInvite](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvite.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPartySearchInvites> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPartySearchInvites Clone()
```

#### Returns

 [CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_"></a> Equals\(CMsgGCToClientPartySearchInvites\)

```csharp
public bool Equals(CMsgGCToClientPartySearchInvites other)
```

#### Parameters

`other` [CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_"></a> MergeFrom\(CMsgGCToClientPartySearchInvites\)

```csharp
public void MergeFrom(CMsgGCToClientPartySearchInvites other)
```

#### Parameters

`other` [CMsgGCToClientPartySearchInvites](Divine.Protobufs.Dota2.CMsgGCToClientPartySearchInvites.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPartySearchInvites_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

