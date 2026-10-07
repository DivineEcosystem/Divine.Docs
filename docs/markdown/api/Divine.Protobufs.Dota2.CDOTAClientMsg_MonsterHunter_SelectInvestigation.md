# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation"></a> Class CDOTAClientMsg\_MonsterHunter\_SelectInvestigation

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_MonsterHunter_SelectInvestigation : IMessage<CDOTAClientMsg_MonsterHunter_SelectInvestigation>, IEquatable<CDOTAClientMsg_MonsterHunter_SelectInvestigation>, IDeepCloneable<CDOTAClientMsg_MonsterHunter_SelectInvestigation>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_MonsterHunter\_SelectInvestigation](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_SelectInvestigation.md)

#### Implements

IMessage<CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\>, 
[IEquatable<CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\>\(CDOTAClientMsg\_MonsterHunter\_SelectInvestigation, params CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation__ctor"></a> CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\(\)

```csharp
public CDOTAClientMsg_MonsterHunter_SelectInvestigation()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_"></a> CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\(CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\)

```csharp
public CDOTAClientMsg_MonsterHunter_SelectInvestigation(CDOTAClientMsg_MonsterHunter_SelectInvestigation other)
```

#### Parameters

`other` [CDOTAClientMsg\_MonsterHunter\_SelectInvestigation](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_SelectInvestigation.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_InvestigationIndexFieldNumber"></a> InvestigationIndexFieldNumber

```csharp
public const int InvestigationIndexFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_HasInvestigationIndex"></a> HasInvestigationIndex

```csharp
public bool HasInvestigationIndex { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_InvestigationIndex"></a> InvestigationIndex

```csharp
public uint InvestigationIndex { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_MonsterHunter_SelectInvestigation> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_MonsterHunter\_SelectInvestigation](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_SelectInvestigation.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_ClearInvestigationIndex"></a> ClearInvestigationIndex\(\)

```csharp
public void ClearInvestigationIndex()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_MonsterHunter_SelectInvestigation Clone()
```

#### Returns

 [CDOTAClientMsg\_MonsterHunter\_SelectInvestigation](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_SelectInvestigation.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_"></a> Equals\(CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\)

```csharp
public bool Equals(CDOTAClientMsg_MonsterHunter_SelectInvestigation other)
```

#### Parameters

`other` [CDOTAClientMsg\_MonsterHunter\_SelectInvestigation](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_SelectInvestigation.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_"></a> MergeFrom\(CDOTAClientMsg\_MonsterHunter\_SelectInvestigation\)

```csharp
public void MergeFrom(CDOTAClientMsg_MonsterHunter_SelectInvestigation other)
```

#### Parameters

`other` [CDOTAClientMsg\_MonsterHunter\_SelectInvestigation](Divine.Protobufs.Dota2.CDOTAClientMsg\_MonsterHunter\_SelectInvestigation.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_MonsterHunter_SelectInvestigation_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

