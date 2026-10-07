# <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession"></a> Class CMsgClientToGCLeavePrivateCoachingSession

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCLeavePrivateCoachingSession : IMessage<CMsgClientToGCLeavePrivateCoachingSession>, IEquatable<CMsgClientToGCLeavePrivateCoachingSession>, IDeepCloneable<CMsgClientToGCLeavePrivateCoachingSession>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCLeavePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCLeavePrivateCoachingSession.md)

#### Implements

IMessage<CMsgClientToGCLeavePrivateCoachingSession\>, 
[IEquatable<CMsgClientToGCLeavePrivateCoachingSession\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCLeavePrivateCoachingSession\>, 
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
[EnumerableExtensions.In<CMsgClientToGCLeavePrivateCoachingSession\>\(CMsgClientToGCLeavePrivateCoachingSession, params CMsgClientToGCLeavePrivateCoachingSession\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession__ctor"></a> CMsgClientToGCLeavePrivateCoachingSession\(\)

```csharp
public CMsgClientToGCLeavePrivateCoachingSession()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession__ctor_Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_"></a> CMsgClientToGCLeavePrivateCoachingSession\(CMsgClientToGCLeavePrivateCoachingSession\)

```csharp
public CMsgClientToGCLeavePrivateCoachingSession(CMsgClientToGCLeavePrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCLeavePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCLeavePrivateCoachingSession.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCLeavePrivateCoachingSession> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCLeavePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCLeavePrivateCoachingSession.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCLeavePrivateCoachingSession Clone()
```

#### Returns

 [CMsgClientToGCLeavePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCLeavePrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_Equals_Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_"></a> Equals\(CMsgClientToGCLeavePrivateCoachingSession\)

```csharp
public bool Equals(CMsgClientToGCLeavePrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCLeavePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCLeavePrivateCoachingSession.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_"></a> MergeFrom\(CMsgClientToGCLeavePrivateCoachingSession\)

```csharp
public void MergeFrom(CMsgClientToGCLeavePrivateCoachingSession other)
```

#### Parameters

`other` [CMsgClientToGCLeavePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgClientToGCLeavePrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeavePrivateCoachingSession_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

