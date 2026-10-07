# <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary"></a> Class CMsgAvailablePrivateCoachingSessionSummary

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAvailablePrivateCoachingSessionSummary : IMessage<CMsgAvailablePrivateCoachingSessionSummary>, IEquatable<CMsgAvailablePrivateCoachingSessionSummary>, IDeepCloneable<CMsgAvailablePrivateCoachingSessionSummary>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)

#### Implements

IMessage<CMsgAvailablePrivateCoachingSessionSummary\>, 
[IEquatable<CMsgAvailablePrivateCoachingSessionSummary\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAvailablePrivateCoachingSessionSummary\>, 
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
[EnumerableExtensions.In<CMsgAvailablePrivateCoachingSessionSummary\>\(CMsgAvailablePrivateCoachingSessionSummary, params CMsgAvailablePrivateCoachingSessionSummary\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary__ctor"></a> CMsgAvailablePrivateCoachingSessionSummary\(\)

```csharp
public CMsgAvailablePrivateCoachingSessionSummary()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary__ctor_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_"></a> CMsgAvailablePrivateCoachingSessionSummary\(CMsgAvailablePrivateCoachingSessionSummary\)

```csharp
public CMsgAvailablePrivateCoachingSessionSummary(CMsgAvailablePrivateCoachingSessionSummary other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_CoachingSessionCountFieldNumber"></a> CoachingSessionCountFieldNumber

```csharp
public const int CoachingSessionCountFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_CoachingSessionCount"></a> CoachingSessionCount

```csharp
public uint CoachingSessionCount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_HasCoachingSessionCount"></a> HasCoachingSessionCount

```csharp
public bool HasCoachingSessionCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAvailablePrivateCoachingSessionSummary> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_ClearCoachingSessionCount"></a> ClearCoachingSessionCount\(\)

```csharp
public void ClearCoachingSessionCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_Clone"></a> Clone\(\)

```csharp
public CMsgAvailablePrivateCoachingSessionSummary Clone()
```

#### Returns

 [CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_Equals_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_"></a> Equals\(CMsgAvailablePrivateCoachingSessionSummary\)

```csharp
public bool Equals(CMsgAvailablePrivateCoachingSessionSummary other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_MergeFrom_Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_"></a> MergeFrom\(CMsgAvailablePrivateCoachingSessionSummary\)

```csharp
public void MergeFrom(CMsgAvailablePrivateCoachingSessionSummary other)
```

#### Parameters

`other` [CMsgAvailablePrivateCoachingSessionSummary](Divine.Protobufs.Dota2.CMsgAvailablePrivateCoachingSessionSummary.md)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgAvailablePrivateCoachingSessionSummary_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

