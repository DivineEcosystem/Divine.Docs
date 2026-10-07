# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption"></a> Class CDOTAClientMsg\_GuideSelectOption

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_GuideSelectOption : IMessage<CDOTAClientMsg_GuideSelectOption>, IEquatable<CDOTAClientMsg_GuideSelectOption>, IDeepCloneable<CDOTAClientMsg_GuideSelectOption>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_GuideSelectOption](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelectOption.md)

#### Implements

IMessage<CDOTAClientMsg\_GuideSelectOption\>, 
[IEquatable<CDOTAClientMsg\_GuideSelectOption\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_GuideSelectOption\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_GuideSelectOption\>\(CDOTAClientMsg\_GuideSelectOption, params CDOTAClientMsg\_GuideSelectOption\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption__ctor"></a> CDOTAClientMsg\_GuideSelectOption\(\)

```csharp
public CDOTAClientMsg_GuideSelectOption()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_"></a> CDOTAClientMsg\_GuideSelectOption\(CDOTAClientMsg\_GuideSelectOption\)

```csharp
public CDOTAClientMsg_GuideSelectOption(CDOTAClientMsg_GuideSelectOption other)
```

#### Parameters

`other` [CDOTAClientMsg\_GuideSelectOption](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelectOption.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_ForceRecalculateFieldNumber"></a> ForceRecalculateFieldNumber

```csharp
public const int ForceRecalculateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_OptionFieldNumber"></a> OptionFieldNumber

```csharp
public const int OptionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_ForceRecalculate"></a> ForceRecalculate

```csharp
public bool ForceRecalculate { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_HasForceRecalculate"></a> HasForceRecalculate

```csharp
public bool HasForceRecalculate { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_HasOption"></a> HasOption

```csharp
public bool HasOption { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_Option"></a> Option

```csharp
public uint Option { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_GuideSelectOption> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_GuideSelectOption](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelectOption.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_ClearForceRecalculate"></a> ClearForceRecalculate\(\)

```csharp
public void ClearForceRecalculate()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_ClearOption"></a> ClearOption\(\)

```csharp
public void ClearOption()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_GuideSelectOption Clone()
```

#### Returns

 [CDOTAClientMsg\_GuideSelectOption](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelectOption.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_"></a> Equals\(CDOTAClientMsg\_GuideSelectOption\)

```csharp
public bool Equals(CDOTAClientMsg_GuideSelectOption other)
```

#### Parameters

`other` [CDOTAClientMsg\_GuideSelectOption](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelectOption.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_"></a> MergeFrom\(CDOTAClientMsg\_GuideSelectOption\)

```csharp
public void MergeFrom(CDOTAClientMsg_GuideSelectOption other)
```

#### Parameters

`other` [CDOTAClientMsg\_GuideSelectOption](Divine.Protobufs.Dota2.CDOTAClientMsg\_GuideSelectOption.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_GuideSelectOption_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

