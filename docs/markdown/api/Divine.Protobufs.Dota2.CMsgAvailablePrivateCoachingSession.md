# <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession"></a> Class CMsgAvailablePrivateCoachingSession

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAvailablePrivateCoachingSession : IMessage<CMsgAvailablePrivateCoachingSession>, IEquatable<CMsgAvailablePrivateCoachingSession>, IDeepCloneable<CMsgAvailablePrivateCoachingSession>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)

#### Implements

IMessage<CMsgAvailablePrivateCoachingSession\>, 
[IEquatable<CMsgAvailablePrivateCoachingSession\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAvailablePrivateCoachingSession\>, 
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
[EnumerableExtensions.In<CMsgAvailablePrivateCoachingSession\>\(CMsgAvailablePrivateCoachingSession, params CMsgAvailablePrivateCoachingSession\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession__ctor"></a> CMsgAvailablePrivateCoachingSession\(\)

```csharp
public CMsgAvailablePrivateCoachingSession()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession__ctor_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_"></a> CMsgAvailablePrivateCoachingSession\(CMsgAvailablePrivateCoachingSession\)

```csharp
public CMsgAvailablePrivateCoachingSession(CMsgAvailablePrivateCoachingSession other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_CoachingSessionFieldNumber"></a> CoachingSessionFieldNumber

```csharp
public const int CoachingSessionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_CoachingSessionStatusFieldNumber"></a> CoachingSessionStatusFieldNumber

```csharp
public const int CoachingSessionStatusFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_CoachingSession"></a> CoachingSession

```csharp
public CMsgPrivateCoachingSession CoachingSession { get; set; }
```

#### Property Value

 [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_CoachingSessionStatus"></a> CoachingSessionStatus

```csharp
public CMsgPrivateCoachingSessionStatus CoachingSessionStatus { get; set; }
```

#### Property Value

 [CMsgPrivateCoachingSessionStatus](Divine.Protobufs.Dota2.CMsgPrivateCoachingSessionStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAvailablePrivateCoachingSession> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_Clone"></a> Clone\(\)

```csharp
public CMsgAvailablePrivateCoachingSession Clone()
```

#### Returns

 [CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_Equals_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_"></a> Equals\(CMsgAvailablePrivateCoachingSession\)

```csharp
public bool Equals(CMsgAvailablePrivateCoachingSession other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_MergeFrom_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_"></a> MergeFrom\(CMsgAvailablePrivateCoachingSession\)

```csharp
public void MergeFrom(CMsgAvailablePrivateCoachingSession other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSession_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

