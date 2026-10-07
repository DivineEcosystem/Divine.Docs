# <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList"></a> Class CMsgAvailablePrivateCoachingSessionList

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAvailablePrivateCoachingSessionList : IMessage<CMsgAvailablePrivateCoachingSessionList>, IEquatable<CMsgAvailablePrivateCoachingSessionList>, IDeepCloneable<CMsgAvailablePrivateCoachingSessionList>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)

#### Implements

IMessage<CMsgAvailablePrivateCoachingSessionList\>, 
[IEquatable<CMsgAvailablePrivateCoachingSessionList\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAvailablePrivateCoachingSessionList\>, 
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
[EnumerableExtensions.In<CMsgAvailablePrivateCoachingSessionList\>\(CMsgAvailablePrivateCoachingSessionList, params CMsgAvailablePrivateCoachingSessionList\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList__ctor"></a> CMsgAvailablePrivateCoachingSessionList\(\)

```csharp
public CMsgAvailablePrivateCoachingSessionList()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList__ctor_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_"></a> CMsgAvailablePrivateCoachingSessionList\(CMsgAvailablePrivateCoachingSessionList\)

```csharp
public CMsgAvailablePrivateCoachingSessionList(CMsgAvailablePrivateCoachingSessionList other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_AvailableCoachingSessionsFieldNumber"></a> AvailableCoachingSessionsFieldNumber

```csharp
public const int AvailableCoachingSessionsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_AvailableCoachingSessions"></a> AvailableCoachingSessions

```csharp
public RepeatedField<CMsgAvailablePrivateCoachingSession> AvailableCoachingSessions { get; }
```

#### Property Value

 RepeatedField<[CMsgAvailablePrivateCoachingSession](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSession.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAvailablePrivateCoachingSessionList> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_Clone"></a> Clone\(\)

```csharp
public CMsgAvailablePrivateCoachingSessionList Clone()
```

#### Returns

 [CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_Equals_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_"></a> Equals\(CMsgAvailablePrivateCoachingSessionList\)

```csharp
public bool Equals(CMsgAvailablePrivateCoachingSessionList other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_MergeFrom_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_"></a> MergeFrom\(CMsgAvailablePrivateCoachingSessionList\)

```csharp
public void MergeFrom(CMsgAvailablePrivateCoachingSessionList other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSessionList](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionList.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionList_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

