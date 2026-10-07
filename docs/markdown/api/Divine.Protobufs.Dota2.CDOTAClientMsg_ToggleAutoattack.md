# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack"></a> Class CDOTAClientMsg\_ToggleAutoattack

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_ToggleAutoattack : IMessage<CDOTAClientMsg_ToggleAutoattack>, IEquatable<CDOTAClientMsg_ToggleAutoattack>, IDeepCloneable<CDOTAClientMsg_ToggleAutoattack>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_ToggleAutoattack](Divine.Protobufs.Dota2.CDOTAClientMsg\_ToggleAutoattack.md)

#### Implements

IMessage<CDOTAClientMsg\_ToggleAutoattack\>, 
[IEquatable<CDOTAClientMsg\_ToggleAutoattack\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_ToggleAutoattack\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_ToggleAutoattack\>\(CDOTAClientMsg\_ToggleAutoattack, params CDOTAClientMsg\_ToggleAutoattack\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack__ctor"></a> CDOTAClientMsg\_ToggleAutoattack\(\)

```csharp
public CDOTAClientMsg_ToggleAutoattack()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_"></a> CDOTAClientMsg\_ToggleAutoattack\(CDOTAClientMsg\_ToggleAutoattack\)

```csharp
public CDOTAClientMsg_ToggleAutoattack(CDOTAClientMsg_ToggleAutoattack other)
```

#### Parameters

`other` [CDOTAClientMsg\_ToggleAutoattack](Divine.Protobufs.Dota2.CDOTAClientMsg\_ToggleAutoattack.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_ModeFieldNumber"></a> ModeFieldNumber

```csharp
public const int ModeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_ShowMessageFieldNumber"></a> ShowMessageFieldNumber

```csharp
public const int ShowMessageFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_HasMode"></a> HasMode

```csharp
public bool HasMode { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_HasShowMessage"></a> HasShowMessage

```csharp
public bool HasShowMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_Mode"></a> Mode

```csharp
public int Mode { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_ToggleAutoattack> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_ToggleAutoattack](Divine.Protobufs.Dota2.CDOTAClientMsg\_ToggleAutoattack.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_ShowMessage"></a> ShowMessage

```csharp
public bool ShowMessage { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_ClearMode"></a> ClearMode\(\)

```csharp
public void ClearMode()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_ClearShowMessage"></a> ClearShowMessage\(\)

```csharp
public void ClearShowMessage()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_ToggleAutoattack Clone()
```

#### Returns

 [CDOTAClientMsg\_ToggleAutoattack](Divine.Protobufs.Dota2.CDOTAClientMsg\_ToggleAutoattack.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_"></a> Equals\(CDOTAClientMsg\_ToggleAutoattack\)

```csharp
public bool Equals(CDOTAClientMsg_ToggleAutoattack other)
```

#### Parameters

`other` [CDOTAClientMsg\_ToggleAutoattack](Divine.Protobufs.Dota2.CDOTAClientMsg\_ToggleAutoattack.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_"></a> MergeFrom\(CDOTAClientMsg\_ToggleAutoattack\)

```csharp
public void MergeFrom(CDOTAClientMsg_ToggleAutoattack other)
```

#### Parameters

`other` [CDOTAClientMsg\_ToggleAutoattack](Divine.Protobufs.Dota2.CDOTAClientMsg\_ToggleAutoattack.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_ToggleAutoattack_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

