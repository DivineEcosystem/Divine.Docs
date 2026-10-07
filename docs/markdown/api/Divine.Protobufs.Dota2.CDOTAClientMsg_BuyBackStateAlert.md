# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert"></a> Class CDOTAClientMsg\_BuyBackStateAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_BuyBackStateAlert : IMessage<CDOTAClientMsg_BuyBackStateAlert>, IEquatable<CDOTAClientMsg_BuyBackStateAlert>, IDeepCloneable<CDOTAClientMsg_BuyBackStateAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_BuyBackStateAlert.md)

#### Implements

IMessage<CDOTAClientMsg\_BuyBackStateAlert\>, 
[IEquatable<CDOTAClientMsg\_BuyBackStateAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_BuyBackStateAlert\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_BuyBackStateAlert\>\(CDOTAClientMsg\_BuyBackStateAlert, params CDOTAClientMsg\_BuyBackStateAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert__ctor"></a> CDOTAClientMsg\_BuyBackStateAlert\(\)

```csharp
public CDOTAClientMsg_BuyBackStateAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_"></a> CDOTAClientMsg\_BuyBackStateAlert\(CDOTAClientMsg\_BuyBackStateAlert\)

```csharp
public CDOTAClientMsg_BuyBackStateAlert(CDOTAClientMsg_BuyBackStateAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_BuyBackStateAlert.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_BuyBackStateAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_BuyBackStateAlert.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_BuyBackStateAlert Clone()
```

#### Returns

 [CDOTAClientMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_BuyBackStateAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_"></a> Equals\(CDOTAClientMsg\_BuyBackStateAlert\)

```csharp
public bool Equals(CDOTAClientMsg_BuyBackStateAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_BuyBackStateAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_"></a> MergeFrom\(CDOTAClientMsg\_BuyBackStateAlert\)

```csharp
public void MergeFrom(CDOTAClientMsg_BuyBackStateAlert other)
```

#### Parameters

`other` [CDOTAClientMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAClientMsg\_BuyBackStateAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_BuyBackStateAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

