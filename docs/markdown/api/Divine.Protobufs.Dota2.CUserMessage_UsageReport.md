# <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport"></a> Class CUserMessage\_UsageReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_UsageReport : IMessage<CUserMessage_UsageReport>, IEquatable<CUserMessage_UsageReport>, IDeepCloneable<CUserMessage_UsageReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_UsageReport](Divine.Protobufs.Dota2.CUserMessage\_UsageReport.md)

#### Implements

IMessage<CUserMessage\_UsageReport\>, 
[IEquatable<CUserMessage\_UsageReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_UsageReport\>, 
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
[EnumerableExtensions.In<CUserMessage\_UsageReport\>\(CUserMessage\_UsageReport, params CUserMessage\_UsageReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport__ctor"></a> CUserMessage\_UsageReport\(\)

```csharp
public CUserMessage_UsageReport()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport__ctor_Divine_Protobufs_Dota2_CUserMessage_UsageReport_"></a> CUserMessage\_UsageReport\(CUserMessage\_UsageReport\)

```csharp
public CUserMessage_UsageReport(CUserMessage_UsageReport other)
```

#### Parameters

`other` [CUserMessage\_UsageReport](Divine.Protobufs.Dota2.CUserMessage\_UsageReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_UsageFieldNumber"></a> UsageFieldNumber

```csharp
public const int UsageFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_HasUsage"></a> HasUsage

```csharp
public bool HasUsage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_UsageReport> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_UsageReport](Divine.Protobufs.Dota2.CUserMessage\_UsageReport.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_Usage"></a> Usage

```csharp
public string Usage { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_ClearUsage"></a> ClearUsage\(\)

```csharp
public void ClearUsage()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_Clone"></a> Clone\(\)

```csharp
public CUserMessage_UsageReport Clone()
```

#### Returns

 [CUserMessage\_UsageReport](Divine.Protobufs.Dota2.CUserMessage\_UsageReport.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_Equals_Divine_Protobufs_Dota2_CUserMessage_UsageReport_"></a> Equals\(CUserMessage\_UsageReport\)

```csharp
public bool Equals(CUserMessage_UsageReport other)
```

#### Parameters

`other` [CUserMessage\_UsageReport](Divine.Protobufs.Dota2.CUserMessage\_UsageReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_UsageReport_"></a> MergeFrom\(CUserMessage\_UsageReport\)

```csharp
public void MergeFrom(CUserMessage_UsageReport other)
```

#### Parameters

`other` [CUserMessage\_UsageReport](Divine.Protobufs.Dota2.CUserMessage\_UsageReport.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UsageReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

