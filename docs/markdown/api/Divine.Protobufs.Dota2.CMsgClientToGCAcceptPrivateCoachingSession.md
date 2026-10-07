# <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession"></a> Class CMsgClientToGCAcceptPrivateCoachingSession

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCAcceptPrivateCoachingSession : IMessage<CMsgClientToGCAcceptPrivateCoachingSession>, IEquatable<CMsgClientToGCAcceptPrivateCoachingSession>, IDeepCloneable<CMsgClientToGCAcceptPrivateCoachingSession>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCAcceptPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCAcceptPrivateCoachingSession.md)

#### Implements

IMessage<CMsgClientToGCAcceptPrivateCoachingSession\>, 
[IEquatable<CMsgClientToGCAcceptPrivateCoachingSession\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCAcceptPrivateCoachingSession\>, 
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
[EnumerableExtensions.In<CMsgClientToGCAcceptPrivateCoachingSession\>\(CMsgClientToGCAcceptPrivateCoachingSession, params CMsgClientToGCAcceptPrivateCoachingSession\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession__ctor"></a> CMsgClientToGCAcceptPrivateCoachingSession\(\)

```csharp
public CMsgClientToGCAcceptPrivateCoachingSession()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession__ctor_Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_"></a> CMsgClientToGCAcceptPrivateCoachingSession\(CMsgClientToGCAcceptPrivateCoachingSession\)

```csharp
public CMsgClientToGCAcceptPrivateCoachingSession(CMsgClientToGCAcceptPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCAcceptPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCAcceptPrivateCoachingSession.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_CoachingSessionIdFieldNumber"></a> CoachingSessionIdFieldNumber

```csharp
public const int CoachingSessionIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_CoachingSessionId"></a> CoachingSessionId

```csharp
public ulong CoachingSessionId { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_HasCoachingSessionId"></a> HasCoachingSessionId

```csharp
public bool HasCoachingSessionId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCAcceptPrivateCoachingSession> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCAcceptPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCAcceptPrivateCoachingSession.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_ClearCoachingSessionId"></a> ClearCoachingSessionId\(\)

```csharp
public void ClearCoachingSessionId()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCAcceptPrivateCoachingSession Clone()
```

#### Returns

 [CMsgClientToGCAcceptPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCAcceptPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_Equals_Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_"></a> Equals\(CMsgClientToGCAcceptPrivateCoachingSession\)

```csharp
public bool Equals(CMsgClientToGCAcceptPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCAcceptPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCAcceptPrivateCoachingSession.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_"></a> MergeFrom\(CMsgClientToGCAcceptPrivateCoachingSession\)

```csharp
public void MergeFrom(CMsgClientToGCAcceptPrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCAcceptPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCAcceptPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCAcceptPrivateCoachingSession_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

