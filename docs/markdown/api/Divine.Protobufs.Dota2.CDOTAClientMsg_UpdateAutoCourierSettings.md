# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings"></a> Class CDOTAClientMsg\_UpdateAutoCourierSettings

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_UpdateAutoCourierSettings : IMessage<CDOTAClientMsg_UpdateAutoCourierSettings>, IEquatable<CDOTAClientMsg_UpdateAutoCourierSettings>, IDeepCloneable<CDOTAClientMsg_UpdateAutoCourierSettings>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_UpdateAutoCourierSettings](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateAutoCourierSettings.md)

#### Implements

IMessage<CDOTAClientMsg\_UpdateAutoCourierSettings\>, 
[IEquatable<CDOTAClientMsg\_UpdateAutoCourierSettings\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_UpdateAutoCourierSettings\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_UpdateAutoCourierSettings\>\(CDOTAClientMsg\_UpdateAutoCourierSettings, params CDOTAClientMsg\_UpdateAutoCourierSettings\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings__ctor"></a> CDOTAClientMsg\_UpdateAutoCourierSettings\(\)

```csharp
public CDOTAClientMsg_UpdateAutoCourierSettings()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_"></a> CDOTAClientMsg\_UpdateAutoCourierSettings\(CDOTAClientMsg\_UpdateAutoCourierSettings\)

```csharp
public CDOTAClientMsg_UpdateAutoCourierSettings(CDOTAClientMsg_UpdateAutoCourierSettings other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateAutoCourierSettings](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateAutoCourierSettings.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_AutoDeliverFieldNumber"></a> AutoDeliverFieldNumber

```csharp
public const int AutoDeliverFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_AutoDeliver"></a> AutoDeliver

```csharp
public bool AutoDeliver { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_HasAutoDeliver"></a> HasAutoDeliver

```csharp
public bool HasAutoDeliver { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_UpdateAutoCourierSettings> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_UpdateAutoCourierSettings](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateAutoCourierSettings.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_ClearAutoDeliver"></a> ClearAutoDeliver\(\)

```csharp
public void ClearAutoDeliver()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_UpdateAutoCourierSettings Clone()
```

#### Returns

 [CDOTAClientMsg\_UpdateAutoCourierSettings](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateAutoCourierSettings.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_"></a> Equals\(CDOTAClientMsg\_UpdateAutoCourierSettings\)

```csharp
public bool Equals(CDOTAClientMsg_UpdateAutoCourierSettings other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateAutoCourierSettings](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateAutoCourierSettings.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_"></a> MergeFrom\(CDOTAClientMsg\_UpdateAutoCourierSettings\)

```csharp
public void MergeFrom(CDOTAClientMsg_UpdateAutoCourierSettings other)
```

#### Parameters

`other` [CDOTAClientMsg\_UpdateAutoCourierSettings](Divine.Protobufs.Dota2.CDOTAClientMsg\_UpdateAutoCourierSettings.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_UpdateAutoCourierSettings_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

