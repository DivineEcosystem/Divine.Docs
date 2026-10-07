# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable"></a> Class CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MonsterHunter_InvestigationsAvailable : IMessage<CDOTAUserMsg_MonsterHunter_InvestigationsAvailable>, IEquatable<CDOTAUserMsg_MonsterHunter_InvestigationsAvailable>, IDeepCloneable<CDOTAUserMsg_MonsterHunter_InvestigationsAvailable>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable.md)

#### Implements

IMessage<CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\>, 
[IEquatable<CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\>\(CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable, params CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable__ctor"></a> CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\(\)

```csharp
public CDOTAUserMsg_MonsterHunter_InvestigationsAvailable()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_"></a> CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\(CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\)

```csharp
public CDOTAUserMsg_MonsterHunter_InvestigationsAvailable(CDOTAUserMsg_MonsterHunter_InvestigationsAvailable other)
```

#### Parameters

`other` [CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_InvestigationsFieldNumber"></a> InvestigationsFieldNumber

```csharp
public const int InvestigationsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_Investigations"></a> Investigations

```csharp
public RepeatedField<CMsgMonsterHunterInvestigation> Investigations { get; }
```

#### Property Value

 RepeatedField<[CMsgMonsterHunterInvestigation](Divine.Protobufs.Dota2.CMsgMonsterHunterInvestigation.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MonsterHunter_InvestigationsAvailable> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MonsterHunter_InvestigationsAvailable Clone()
```

#### Returns

 [CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_"></a> Equals\(CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\)

```csharp
public bool Equals(CDOTAUserMsg_MonsterHunter_InvestigationsAvailable other)
```

#### Parameters

`other` [CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_"></a> MergeFrom\(CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable\)

```csharp
public void MergeFrom(CDOTAUserMsg_MonsterHunter_InvestigationsAvailable other)
```

#### Parameters

`other` [CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable](Divine.Protobufs.Dota2.CDOTAUserMsg\_MonsterHunter\_InvestigationsAvailable.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MonsterHunter_InvestigationsAvailable_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

