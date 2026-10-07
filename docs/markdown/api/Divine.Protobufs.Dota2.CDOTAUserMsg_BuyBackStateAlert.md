# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert"></a> Class CDOTAUserMsg\_BuyBackStateAlert

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_BuyBackStateAlert : IMessage<CDOTAUserMsg_BuyBackStateAlert>, IEquatable<CDOTAUserMsg_BuyBackStateAlert>, IDeepCloneable<CDOTAUserMsg_BuyBackStateAlert>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_BuyBackStateAlert.md)

#### Implements

IMessage<CDOTAUserMsg\_BuyBackStateAlert\>, 
[IEquatable<CDOTAUserMsg\_BuyBackStateAlert\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_BuyBackStateAlert\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_BuyBackStateAlert\>\(CDOTAUserMsg\_BuyBackStateAlert, params CDOTAUserMsg\_BuyBackStateAlert\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert__ctor"></a> CDOTAUserMsg\_BuyBackStateAlert\(\)

```csharp
public CDOTAUserMsg_BuyBackStateAlert()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_"></a> CDOTAUserMsg\_BuyBackStateAlert\(CDOTAUserMsg\_BuyBackStateAlert\)

```csharp
public CDOTAUserMsg_BuyBackStateAlert(CDOTAUserMsg_BuyBackStateAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_BuyBackStateAlert.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_PlayerIdFieldNumber"></a> PlayerIdFieldNumber

```csharp
public const int PlayerIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_HasPlayerId"></a> HasPlayerId

```csharp
public bool HasPlayerId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_BuyBackStateAlert> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_BuyBackStateAlert.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_PlayerId"></a> PlayerId

```csharp
public int PlayerId { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_ClearPlayerId"></a> ClearPlayerId\(\)

```csharp
public void ClearPlayerId()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_BuyBackStateAlert Clone()
```

#### Returns

 [CDOTAUserMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_BuyBackStateAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_"></a> Equals\(CDOTAUserMsg\_BuyBackStateAlert\)

```csharp
public bool Equals(CDOTAUserMsg_BuyBackStateAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_BuyBackStateAlert.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_"></a> MergeFrom\(CDOTAUserMsg\_BuyBackStateAlert\)

```csharp
public void MergeFrom(CDOTAUserMsg_BuyBackStateAlert other)
```

#### Parameters

`other` [CDOTAUserMsg\_BuyBackStateAlert](Divine.Protobufs.Dota2.CDOTAUserMsg\_BuyBackStateAlert.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_BuyBackStateAlert_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

