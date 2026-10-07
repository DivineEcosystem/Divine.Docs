# <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge"></a> Class CMsgServerToGCRerollPlayerChallenge

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCRerollPlayerChallenge : IMessage<CMsgServerToGCRerollPlayerChallenge>, IEquatable<CMsgServerToGCRerollPlayerChallenge>, IDeepCloneable<CMsgServerToGCRerollPlayerChallenge>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCRerollPlayerChallenge.md)

#### Implements

IMessage<CMsgServerToGCRerollPlayerChallenge\>, 
[IEquatable<CMsgServerToGCRerollPlayerChallenge\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCRerollPlayerChallenge\>, 
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
[EnumerableExtensions.In<CMsgServerToGCRerollPlayerChallenge\>\(CMsgServerToGCRerollPlayerChallenge, params CMsgServerToGCRerollPlayerChallenge\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge__ctor"></a> CMsgServerToGCRerollPlayerChallenge\(\)

```csharp
public CMsgServerToGCRerollPlayerChallenge()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge__ctor_Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_"></a> CMsgServerToGCRerollPlayerChallenge\(CMsgServerToGCRerollPlayerChallenge\)

```csharp
public CMsgServerToGCRerollPlayerChallenge(CMsgServerToGCRerollPlayerChallenge other)
```

#### Parameters

`other` [CMsgServerToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCRerollPlayerChallenge.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_RerollMsgFieldNumber"></a> RerollMsgFieldNumber

```csharp
public const int RerollMsgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCRerollPlayerChallenge> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCRerollPlayerChallenge.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_RerollMsg"></a> RerollMsg

```csharp
public CMsgClientToGCRerollPlayerChallenge RerollMsg { get; set; }
```

#### Property Value

 [CMsgClientToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgClientToGCRerollPlayerChallenge.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCRerollPlayerChallenge Clone()
```

#### Returns

 [CMsgServerToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCRerollPlayerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_Equals_Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_"></a> Equals\(CMsgServerToGCRerollPlayerChallenge\)

```csharp
public bool Equals(CMsgServerToGCRerollPlayerChallenge other)
```

#### Parameters

`other` [CMsgServerToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCRerollPlayerChallenge.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_"></a> MergeFrom\(CMsgServerToGCRerollPlayerChallenge\)

```csharp
public void MergeFrom(CMsgServerToGCRerollPlayerChallenge other)
```

#### Parameters

`other` [CMsgServerToGCRerollPlayerChallenge](Divine.Protobufs.Dota2.CMsgServerToGCRerollPlayerChallenge.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRerollPlayerChallenge_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

