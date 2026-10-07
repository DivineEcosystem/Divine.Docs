# <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest"></a> Class CMsgDOTASelectionPriorityChoiceRequest

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTASelectionPriorityChoiceRequest : IMessage<CMsgDOTASelectionPriorityChoiceRequest>, IEquatable<CMsgDOTASelectionPriorityChoiceRequest>, IDeepCloneable<CMsgDOTASelectionPriorityChoiceRequest>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTASelectionPriorityChoiceRequest](Divine.Protobufs.Dota2.CMsgDOTASelectionPriorityChoiceRequest.md)

#### Implements

IMessage<CMsgDOTASelectionPriorityChoiceRequest\>, 
[IEquatable<CMsgDOTASelectionPriorityChoiceRequest\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTASelectionPriorityChoiceRequest\>, 
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
[EnumerableExtensions.In<CMsgDOTASelectionPriorityChoiceRequest\>\(CMsgDOTASelectionPriorityChoiceRequest, params CMsgDOTASelectionPriorityChoiceRequest\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest__ctor"></a> CMsgDOTASelectionPriorityChoiceRequest\(\)

```csharp
public CMsgDOTASelectionPriorityChoiceRequest()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest__ctor_Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_"></a> CMsgDOTASelectionPriorityChoiceRequest\(CMsgDOTASelectionPriorityChoiceRequest\)

```csharp
public CMsgDOTASelectionPriorityChoiceRequest(CMsgDOTASelectionPriorityChoiceRequest other)
```

#### Parameters

`other` [CMsgDOTASelectionPriorityChoiceRequest](Divine.Protobufs.Dota2.CMsgDOTASelectionPriorityChoiceRequest.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_ChoiceFieldNumber"></a> ChoiceFieldNumber

```csharp
public const int ChoiceFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_Choice"></a> Choice

```csharp
public DOTASelectionPriorityChoice Choice { get; set; }
```

#### Property Value

 [DOTASelectionPriorityChoice](Divine.Protobufs.Dota2.DOTASelectionPriorityChoice.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_HasChoice"></a> HasChoice

```csharp
public bool HasChoice { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTASelectionPriorityChoiceRequest> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTASelectionPriorityChoiceRequest](Divine.Protobufs.Dota2.CMsgDOTASelectionPriorityChoiceRequest.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_ClearChoice"></a> ClearChoice\(\)

```csharp
public void ClearChoice()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_Clone"></a> Clone\(\)

```csharp
public CMsgDOTASelectionPriorityChoiceRequest Clone()
```

#### Returns

 [CMsgDOTASelectionPriorityChoiceRequest](Divine.Protobufs.Dota2.CMsgDOTASelectionPriorityChoiceRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_Equals_Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_"></a> Equals\(CMsgDOTASelectionPriorityChoiceRequest\)

```csharp
public bool Equals(CMsgDOTASelectionPriorityChoiceRequest other)
```

#### Parameters

`other` [CMsgDOTASelectionPriorityChoiceRequest](Divine.Protobufs.Dota2.CMsgDOTASelectionPriorityChoiceRequest.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_"></a> MergeFrom\(CMsgDOTASelectionPriorityChoiceRequest\)

```csharp
public void MergeFrom(CMsgDOTASelectionPriorityChoiceRequest other)
```

#### Parameters

`other` [CMsgDOTASelectionPriorityChoiceRequest](Divine.Protobufs.Dota2.CMsgDOTASelectionPriorityChoiceRequest.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTASelectionPriorityChoiceRequest_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

