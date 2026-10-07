# <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated"></a> Class CMsgGCToClientPrivateCoachingSessionUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientPrivateCoachingSessionUpdated : IMessage<CMsgGCToClientPrivateCoachingSessionUpdated>, IEquatable<CMsgGCToClientPrivateCoachingSessionUpdated>, IDeepCloneable<CMsgGCToClientPrivateCoachingSessionUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientPrivateCoachingSessionUpdated](Divine.Protobufs.Dota2.CMsgGCToClientPrivateCoachingSessionUpdated.md)

#### Implements

IMessage<CMsgGCToClientPrivateCoachingSessionUpdated\>, 
[IEquatable<CMsgGCToClientPrivateCoachingSessionUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientPrivateCoachingSessionUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientPrivateCoachingSessionUpdated\>\(CMsgGCToClientPrivateCoachingSessionUpdated, params CMsgGCToClientPrivateCoachingSessionUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated__ctor"></a> CMsgGCToClientPrivateCoachingSessionUpdated\(\)

```csharp
public CMsgGCToClientPrivateCoachingSessionUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_"></a> CMsgGCToClientPrivateCoachingSessionUpdated\(CMsgGCToClientPrivateCoachingSessionUpdated\)

```csharp
public CMsgGCToClientPrivateCoachingSessionUpdated(CMsgGCToClientPrivateCoachingSessionUpdated other)
```

#### Parameters

`other` [CMsgGCToClientPrivateCoachingSessionUpdated](Divine.Protobufs.Dota2.CMsgGCToClientPrivateCoachingSessionUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_CoachingSessionFieldNumber"></a> CoachingSessionFieldNumber

```csharp
public const int CoachingSessionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_CoachingSession"></a> CoachingSession

```csharp
public CMsgPrivateCoachingSession CoachingSession { get; set; }
```

#### Property Value

 [CMsgPrivateCoachingSession](Divine.Protobufs.Dota2.CMsgPrivateCoachingSession.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientPrivateCoachingSessionUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientPrivateCoachingSessionUpdated](Divine.Protobufs.Dota2.CMsgGCToClientPrivateCoachingSessionUpdated.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientPrivateCoachingSessionUpdated Clone()
```

#### Returns

 [CMsgGCToClientPrivateCoachingSessionUpdated](Divine.Protobufs.Dota2.CMsgGCToClientPrivateCoachingSessionUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_"></a> Equals\(CMsgGCToClientPrivateCoachingSessionUpdated\)

```csharp
public bool Equals(CMsgGCToClientPrivateCoachingSessionUpdated other)
```

#### Parameters

`other` [CMsgGCToClientPrivateCoachingSessionUpdated](Divine.Protobufs.Dota2.CMsgGCToClientPrivateCoachingSessionUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_"></a> MergeFrom\(CMsgGCToClientPrivateCoachingSessionUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientPrivateCoachingSessionUpdated other)
```

#### Parameters

`other` [CMsgGCToClientPrivateCoachingSessionUpdated](Divine.Protobufs.Dota2.CMsgGCToClientPrivateCoachingSessionUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientPrivateCoachingSessionUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

