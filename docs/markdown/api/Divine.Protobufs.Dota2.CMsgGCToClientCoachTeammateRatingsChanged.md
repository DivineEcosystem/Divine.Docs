# <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged"></a> Class CMsgGCToClientCoachTeammateRatingsChanged

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientCoachTeammateRatingsChanged : IMessage<CMsgGCToClientCoachTeammateRatingsChanged>, IEquatable<CMsgGCToClientCoachTeammateRatingsChanged>, IDeepCloneable<CMsgGCToClientCoachTeammateRatingsChanged>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientCoachTeammateRatingsChanged](Divine.Protobufs.Dota2.CMsgGCToClientCoachTeammateRatingsChanged.md)

#### Implements

IMessage<CMsgGCToClientCoachTeammateRatingsChanged\>, 
[IEquatable<CMsgGCToClientCoachTeammateRatingsChanged\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientCoachTeammateRatingsChanged\>, 
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
[EnumerableExtensions.In<CMsgGCToClientCoachTeammateRatingsChanged\>\(CMsgGCToClientCoachTeammateRatingsChanged, params CMsgGCToClientCoachTeammateRatingsChanged\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged__ctor"></a> CMsgGCToClientCoachTeammateRatingsChanged\(\)

```csharp
public CMsgGCToClientCoachTeammateRatingsChanged()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged__ctor_Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_"></a> CMsgGCToClientCoachTeammateRatingsChanged\(CMsgGCToClientCoachTeammateRatingsChanged\)

```csharp
public CMsgGCToClientCoachTeammateRatingsChanged(CMsgGCToClientCoachTeammateRatingsChanged other)
```

#### Parameters

`other` [CMsgGCToClientCoachTeammateRatingsChanged](Divine.Protobufs.Dota2.CMsgGCToClientCoachTeammateRatingsChanged.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_CoachMatchFieldNumber"></a> CoachMatchFieldNumber

```csharp
public const int CoachMatchFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_CoachMatch"></a> CoachMatch

```csharp
public CMsgPlayerCoachMatch CoachMatch { get; set; }
```

#### Property Value

 [CMsgPlayerCoachMatch](Divine.Protobufs.Dota2.CMsgPlayerCoachMatch.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientCoachTeammateRatingsChanged> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientCoachTeammateRatingsChanged](Divine.Protobufs.Dota2.CMsgGCToClientCoachTeammateRatingsChanged.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientCoachTeammateRatingsChanged Clone()
```

#### Returns

 [CMsgGCToClientCoachTeammateRatingsChanged](Divine.Protobufs.Dota2.CMsgGCToClientCoachTeammateRatingsChanged.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_Equals_Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_"></a> Equals\(CMsgGCToClientCoachTeammateRatingsChanged\)

```csharp
public bool Equals(CMsgGCToClientCoachTeammateRatingsChanged other)
```

#### Parameters

`other` [CMsgGCToClientCoachTeammateRatingsChanged](Divine.Protobufs.Dota2.CMsgGCToClientCoachTeammateRatingsChanged.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_"></a> MergeFrom\(CMsgGCToClientCoachTeammateRatingsChanged\)

```csharp
public void MergeFrom(CMsgGCToClientCoachTeammateRatingsChanged other)
```

#### Parameters

`other` [CMsgGCToClientCoachTeammateRatingsChanged](Divine.Protobufs.Dota2.CMsgGCToClientCoachTeammateRatingsChanged.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientCoachTeammateRatingsChanged_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

