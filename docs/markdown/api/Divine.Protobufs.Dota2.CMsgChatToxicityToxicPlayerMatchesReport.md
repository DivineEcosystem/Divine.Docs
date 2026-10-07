# <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport"></a> Class CMsgChatToxicityToxicPlayerMatchesReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgChatToxicityToxicPlayerMatchesReport : IMessage<CMsgChatToxicityToxicPlayerMatchesReport>, IEquatable<CMsgChatToxicityToxicPlayerMatchesReport>, IDeepCloneable<CMsgChatToxicityToxicPlayerMatchesReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md)

#### Implements

IMessage<CMsgChatToxicityToxicPlayerMatchesReport\>, 
[IEquatable<CMsgChatToxicityToxicPlayerMatchesReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgChatToxicityToxicPlayerMatchesReport\>, 
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
[EnumerableExtensions.In<CMsgChatToxicityToxicPlayerMatchesReport\>\(CMsgChatToxicityToxicPlayerMatchesReport, params CMsgChatToxicityToxicPlayerMatchesReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport__ctor"></a> CMsgChatToxicityToxicPlayerMatchesReport\(\)

```csharp
public CMsgChatToxicityToxicPlayerMatchesReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport__ctor_Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_"></a> CMsgChatToxicityToxicPlayerMatchesReport\(CMsgChatToxicityToxicPlayerMatchesReport\)

```csharp
public CMsgChatToxicityToxicPlayerMatchesReport(CMsgChatToxicityToxicPlayerMatchesReport other)
```

#### Parameters

`other` [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_RowsFieldNumber"></a> RowsFieldNumber

```csharp
public const int RowsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Parser"></a> Parser

```csharp
public static MessageParser<CMsgChatToxicityToxicPlayerMatchesReport> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Rows"></a> Rows

```csharp
public RepeatedField<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow> Rows { get; }
```

#### Property Value

 RepeatedField<[CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md).[Types](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.md).[IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Clone"></a> Clone\(\)

```csharp
public CMsgChatToxicityToxicPlayerMatchesReport Clone()
```

#### Returns

 [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Equals_Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_"></a> Equals\(CMsgChatToxicityToxicPlayerMatchesReport\)

```csharp
public bool Equals(CMsgChatToxicityToxicPlayerMatchesReport other)
```

#### Parameters

`other` [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_MergeFrom_Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_"></a> MergeFrom\(CMsgChatToxicityToxicPlayerMatchesReport\)

```csharp
public void MergeFrom(CMsgChatToxicityToxicPlayerMatchesReport other)
```

#### Parameters

`other` [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

