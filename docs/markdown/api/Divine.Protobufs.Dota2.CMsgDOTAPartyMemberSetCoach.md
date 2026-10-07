# <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach"></a> Class CMsgDOTAPartyMemberSetCoach

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAPartyMemberSetCoach : IMessage<CMsgDOTAPartyMemberSetCoach>, IEquatable<CMsgDOTAPartyMemberSetCoach>, IDeepCloneable<CMsgDOTAPartyMemberSetCoach>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAPartyMemberSetCoach](Divine.Protobufs.Dota2.CMsgDOTAPartyMemberSetCoach.md)

#### Implements

IMessage<CMsgDOTAPartyMemberSetCoach\>, 
[IEquatable<CMsgDOTAPartyMemberSetCoach\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAPartyMemberSetCoach\>, 
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
[EnumerableExtensions.In<CMsgDOTAPartyMemberSetCoach\>\(CMsgDOTAPartyMemberSetCoach, params CMsgDOTAPartyMemberSetCoach\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach__ctor"></a> CMsgDOTAPartyMemberSetCoach\(\)

```csharp
public CMsgDOTAPartyMemberSetCoach()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach__ctor_Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_"></a> CMsgDOTAPartyMemberSetCoach\(CMsgDOTAPartyMemberSetCoach\)

```csharp
public CMsgDOTAPartyMemberSetCoach(CMsgDOTAPartyMemberSetCoach other)
```

#### Parameters

`other` [CMsgDOTAPartyMemberSetCoach](Divine.Protobufs.Dota2.CMsgDOTAPartyMemberSetCoach.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_WantsCoachFieldNumber"></a> WantsCoachFieldNumber

```csharp
public const int WantsCoachFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_HasWantsCoach"></a> HasWantsCoach

```csharp
public bool HasWantsCoach { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAPartyMemberSetCoach> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAPartyMemberSetCoach](Divine.Protobufs.Dota2.CMsgDOTAPartyMemberSetCoach.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_WantsCoach"></a> WantsCoach

```csharp
public bool WantsCoach { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_ClearWantsCoach"></a> ClearWantsCoach\(\)

```csharp
public void ClearWantsCoach()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAPartyMemberSetCoach Clone()
```

#### Returns

 [CMsgDOTAPartyMemberSetCoach](Divine.Protobufs.Dota2.CMsgDOTAPartyMemberSetCoach.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_Equals_Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_"></a> Equals\(CMsgDOTAPartyMemberSetCoach\)

```csharp
public bool Equals(CMsgDOTAPartyMemberSetCoach other)
```

#### Parameters

`other` [CMsgDOTAPartyMemberSetCoach](Divine.Protobufs.Dota2.CMsgDOTAPartyMemberSetCoach.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_"></a> MergeFrom\(CMsgDOTAPartyMemberSetCoach\)

```csharp
public void MergeFrom(CMsgDOTAPartyMemberSetCoach other)
```

#### Parameters

`other` [CMsgDOTAPartyMemberSetCoach](Divine.Protobufs.Dota2.CMsgDOTAPartyMemberSetCoach.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAPartyMemberSetCoach_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

