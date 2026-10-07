# <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints"></a> Class CMsgLobbyEventPoints

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyEventPoints : IMessage<CMsgLobbyEventPoints>, IEquatable<CMsgLobbyEventPoints>, IDeepCloneable<CMsgLobbyEventPoints>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)

#### Implements

IMessage<CMsgLobbyEventPoints\>, 
[IEquatable<CMsgLobbyEventPoints\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyEventPoints\>, 
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
[EnumerableExtensions.In<CMsgLobbyEventPoints\>\(CMsgLobbyEventPoints, params CMsgLobbyEventPoints\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints__ctor"></a> CMsgLobbyEventPoints\(\)

```csharp
public CMsgLobbyEventPoints()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints__ctor_Divine_Protobufs_Dota2_CMsgLobbyEventPoints_"></a> CMsgLobbyEventPoints\(CMsgLobbyEventPoints\)

```csharp
public CMsgLobbyEventPoints(CMsgLobbyEventPoints other)
```

#### Parameters

`other` [CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_AccountPointsFieldNumber"></a> AccountPointsFieldNumber

```csharp
public const int AccountPointsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_AccountPoints"></a> AccountPoints

```csharp
public RepeatedField<CMsgLobbyEventPoints.Types.AccountPoints> AccountPoints { get; }
```

#### Property Value

 RepeatedField<[CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md).[Types](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.Types.md).[AccountPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.Types.AccountPoints.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_EventId"></a> EventId

```csharp
public uint EventId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_HasEventId"></a> HasEventId

```csharp
public bool HasEventId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyEventPoints> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_ClearEventId"></a> ClearEventId\(\)

```csharp
public void ClearEventId()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyEventPoints Clone()
```

#### Returns

 [CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_Equals_Divine_Protobufs_Dota2_CMsgLobbyEventPoints_"></a> Equals\(CMsgLobbyEventPoints\)

```csharp
public bool Equals(CMsgLobbyEventPoints other)
```

#### Parameters

`other` [CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyEventPoints_"></a> MergeFrom\(CMsgLobbyEventPoints\)

```csharp
public void MergeFrom(CMsgLobbyEventPoints other)
```

#### Parameters

`other` [CMsgLobbyEventPoints](Divine.Protobufs.Dota2.CMsgLobbyEventPoints.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyEventPoints_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

