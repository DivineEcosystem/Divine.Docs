# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP"></a> Class CDOTAUserMsg\_OutpostGrantedXP

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_OutpostGrantedXP : IMessage<CDOTAUserMsg_OutpostGrantedXP>, IEquatable<CDOTAUserMsg_OutpostGrantedXP>, IDeepCloneable<CDOTAUserMsg_OutpostGrantedXP>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_OutpostGrantedXP](Divine.Protobufs.Dota2.CDOTAUserMsg\_OutpostGrantedXP.md)

#### Implements

IMessage<CDOTAUserMsg\_OutpostGrantedXP\>, 
[IEquatable<CDOTAUserMsg\_OutpostGrantedXP\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_OutpostGrantedXP\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_OutpostGrantedXP\>\(CDOTAUserMsg\_OutpostGrantedXP, params CDOTAUserMsg\_OutpostGrantedXP\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP__ctor"></a> CDOTAUserMsg\_OutpostGrantedXP\(\)

```csharp
public CDOTAUserMsg_OutpostGrantedXP()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_"></a> CDOTAUserMsg\_OutpostGrantedXP\(CDOTAUserMsg\_OutpostGrantedXP\)

```csharp
public CDOTAUserMsg_OutpostGrantedXP(CDOTAUserMsg_OutpostGrantedXP other)
```

#### Parameters

`other` [CDOTAUserMsg\_OutpostGrantedXP](Divine.Protobufs.Dota2.CDOTAUserMsg\_OutpostGrantedXP.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_TeamIdFieldNumber"></a> TeamIdFieldNumber

```csharp
public const int TeamIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_XpAmountFieldNumber"></a> XpAmountFieldNumber

```csharp
public const int XpAmountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_HasTeamId"></a> HasTeamId

```csharp
public bool HasTeamId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_HasXpAmount"></a> HasXpAmount

```csharp
public bool HasXpAmount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_OutpostGrantedXP> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_OutpostGrantedXP](Divine.Protobufs.Dota2.CDOTAUserMsg\_OutpostGrantedXP.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_TeamId"></a> TeamId

```csharp
public uint TeamId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_XpAmount"></a> XpAmount

```csharp
public uint XpAmount { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_ClearTeamId"></a> ClearTeamId\(\)

```csharp
public void ClearTeamId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_ClearXpAmount"></a> ClearXpAmount\(\)

```csharp
public void ClearXpAmount()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_OutpostGrantedXP Clone()
```

#### Returns

 [CDOTAUserMsg\_OutpostGrantedXP](Divine.Protobufs.Dota2.CDOTAUserMsg\_OutpostGrantedXP.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_"></a> Equals\(CDOTAUserMsg\_OutpostGrantedXP\)

```csharp
public bool Equals(CDOTAUserMsg_OutpostGrantedXP other)
```

#### Parameters

`other` [CDOTAUserMsg\_OutpostGrantedXP](Divine.Protobufs.Dota2.CDOTAUserMsg\_OutpostGrantedXP.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_"></a> MergeFrom\(CDOTAUserMsg\_OutpostGrantedXP\)

```csharp
public void MergeFrom(CDOTAUserMsg_OutpostGrantedXP other)
```

#### Parameters

`other` [CDOTAUserMsg\_OutpostGrantedXP](Divine.Protobufs.Dota2.CDOTAUserMsg\_OutpostGrantedXP.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_OutpostGrantedXP_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

